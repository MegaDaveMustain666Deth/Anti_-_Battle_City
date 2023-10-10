using UnityEngine;

public abstract class Weapon : MonoBehaviour 
{
    public int damage;

    public virtual void Attack()
    {
        Player.Instance.OnShoot.Invoke();
    }
}