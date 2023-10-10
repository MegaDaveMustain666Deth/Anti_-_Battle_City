using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int health;

    publivc void Start()
    {
        health = maxHealth;
    }

    public abstract void TakeDamage(int damage);

    protected void Dead()
    {
        Destroy(gameObject);
    }
}