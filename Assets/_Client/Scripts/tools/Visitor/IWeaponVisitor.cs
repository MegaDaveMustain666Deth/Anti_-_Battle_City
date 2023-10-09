using UnityEngine;

public interface IWeaponVisitor
{
    public void Visitor(TankWeapon weapon, RaycastHit2D hit); 
}