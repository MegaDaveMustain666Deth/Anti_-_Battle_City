using UnityEngine;

public abstract class WeaponRaycastAttack : Weapon
{
    [SerializeField] protected Transform firePoint;
    [SerializeField] protected GameObject animationPoint;
    [SerializeField] private Collider2D _collider;

    [SerializeField] protected int amountProjectTile;
    [SerializeField] private float distanceShot;

    public virtual void PerformShot()
    {
        animationPoint.SetActive(true);
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, transform.up, distanceShot);

        if (hit)
        {
            ScanHit(hit);
        }
    }

    private void ScanHit(RaycastHit2D hit)
    {
        GameObject gameObjectHit = hit.collider.gameObject;

        if (gameObjectHit.TryGetComponent(out IWeaponVisitor weaponVisitor))
        {
            Accept(weaponVisitor, hit);
        }
    }

    protected abstract void Accept(IWeaponVisitor weaponVisitor, RaycastHit2D hit);
}