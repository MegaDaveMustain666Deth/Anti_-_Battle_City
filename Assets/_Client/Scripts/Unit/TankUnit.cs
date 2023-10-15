using UnityEngine;
using Tools;

public class TankUnit : Unit
{
    public int GetHP() => base.health;
    public override void Initialize()

    {
        base.Initialize();
        _health = new Health(this);
    }

    public override void TakeDamageTank(int damage)
    {
        _health.TakeDamageTank(damage);
    }

    public override void TakeDamageEnviroment(Vector3 tilePosition)
    {

    } 
}