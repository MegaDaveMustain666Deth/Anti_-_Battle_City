using UnityEngine;

public class TankWeapon : WeaponRaycastAttack
{ 

    protected override void Accept(IWeaponVisitor weaponVisitor, RaycastHit2D hit)
    {
        weaponVisitor.Visitor(this, hit);
    }
}  