using UnityEngine;

public class TankWeapon : WeaponRaycastAttack
{
    [SerializeField] private float _timeOfRecharge;

    public override void PerformShot()
    {
        base.PerformShot();
    }

    protected override void Accept(IWeaponVisitor weaponVisitor, RaycastHit2D hit)
    {
        weaponVisitor.Visitor(this, hit);
    }
}  