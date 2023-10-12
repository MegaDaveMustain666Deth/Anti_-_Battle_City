using UnityEngine;

public class TankUnit : Unit
{
    public int GetHP() => base.health;
    public void Health(int health)
    {
        base.health += health;

        print(gameObject.name + health.ToString());

        if(base.health > maxHealth)
        {
            base.health = maxHealth;
        }
    }

    public override void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Dead();
        }
    }
}