using UnityEngine;

public class EnviromentUnit : Unit
{
    public override void TakeDamage(int damage)
    {
        Dead();
    }
}