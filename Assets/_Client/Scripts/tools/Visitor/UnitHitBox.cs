using UnityEngine;

public class UnitHitBox : MonoBehaviour, IWeaponVisitor 
{
    [SerializeField] private TankUnit _unit;
    
    public void Visitor(TankWeapon weapon, RaycastHit2D hit)
    {
        DefaultRaycastVisit(weapon, hit);
    }

    private void DefaultRaycastVisit(Weapon weapon, RaycastHit2D hit)
    {
        _unit.TakeDamage(weapon.damage);
    }
}