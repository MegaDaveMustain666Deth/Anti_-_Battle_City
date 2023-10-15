using UnityEngine;

public class BaseUnit : Unit
{
    public override void TakeDamageTank(int damage)
    {
        Destroy(gameObject);
    }

    public override void TakeDamageEnviroment(Vector3 tilePosition)
    {

    }
}