using UnityEngine;

public abstract class WeaponRaycastAttack : Weapon
{
    [SerializeField] protected Transform firePoint;
    [SerializeField] protected GameObject animationPoint;
    [SerializeField] private Collider2D _collider;

    [SerializeField] protected int amountProjectTile;
    [SerializeField] private float distanceShot;
    [SerializeField] private float _timeOfRecharge;

    private float _currentTimeOfRecharge;
    private Timer timerRechardge;

    public override void Attack()
    {
        if (_timeOfRecharge < timerRechardge?.GetTime() || _timeOfRecharge < _currentTimeOfRecharge)
        {
            _currentTimeOfRecharge = timerRechardge.GetTime();
            timerRechardge.StopCountingTime();
            return;
        }

        base.Attack();

        animationPoint.SetActive(true);
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, transform.up, distanceShot);

        if (hit)
        {
            ScanHit(hit);
        }

        SetTimer();
    }

    private void ScanHit(RaycastHit2D hit)
    {
        GameObject gameObjectHit = hit.collider.gameObject;

        if (gameObjectHit.TryGetComponent(out IWeaponVisitor weaponVisitor))
        {
            Accept(weaponVisitor, hit);
        }
    }

    private void SetTimer()
    {
        timerRechardge = new Timer(this);
        timerRechardge.Set(_timeOfRecharge);
    }

    protected abstract void Accept(IWeaponVisitor weaponVisitor, RaycastHit2D hit);
}