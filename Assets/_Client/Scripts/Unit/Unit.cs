using UnityEngine;
using Tools;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] protected int maxHealth;

    protected Health _health;
    public int health;

    private void Start()
    {
        Initialize(); 
    }

    public virtual void Initialize()
    {
        health = maxHealth;
    }

    public abstract void TakeDamageTank(int damage);

    public abstract void TakeDamageEnviroment(Vector3 tilePosition);
}