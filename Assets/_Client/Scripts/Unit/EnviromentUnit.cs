using UnityEngine;
using UnityEngine.Tilemaps;
using Tools;
using NavMeshPlus.Components;

public class EnviromentUnit : Unit
{
    [SerializeField] private Tilemap _destructibleTilemap;
    [SerializeField] private NavMeshSurface _navMesh;

    public override void Initialize()
    {
        base.Initialize();
        _health = new Health(this, _destructibleTilemap);

    }

    public override void TakeDamageEnviroment(Vector3 tilePosition)
    {
        _destructibleTilemap.SetTile(_destructibleTilemap.WorldToCell(tilePosition), null);
    }

    public override void TakeDamageTank(int damage)
    {
        
    }
}