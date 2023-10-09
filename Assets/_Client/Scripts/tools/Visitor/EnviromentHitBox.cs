using UnityEngine;

public class EnviromentHitBox : MonoBehaviour, IWeaponVisitor
{
    [SerializeField] private EnviromentUnit _unit;

    public void Visitor(TankWeapon weapon, RaycastHit2D hit)
    {
        DefaultRaycastVisit(weapon, hit);
    }

    private void DefaultRaycastVisit(Weapon weapon, RaycastHit2D hit)
    {
        _unit.TakeDamage(weapon.damage);
    }

}