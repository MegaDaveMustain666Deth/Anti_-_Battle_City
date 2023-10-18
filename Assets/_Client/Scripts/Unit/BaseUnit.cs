using UnityEngine;

public class BaseUnit : Unit
{
    [SerializeField] private Win _win;


    public override void TakeDamageTank(int damage)
    {
        _win.DestroyBase();

        Destroy(gameObject);
    }

    public override void TakeDamageEnviroment(Vector3 tilePosition)
    {

    }
}