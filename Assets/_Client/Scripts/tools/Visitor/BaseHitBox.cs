using UnityEngine;

public class BaseHitBox : MonoBehaviour, IWeaponVisitor
{
    [SerializeField] private Unit _unit;

    public void Visitor(TankWeapon weapon, RaycastHit2D hit)
    {
        _unit.TakeDamageTank(weapon.damage);
    }
}