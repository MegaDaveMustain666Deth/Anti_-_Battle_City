using UnityEngine;
using UnityEngine.Tilemaps;

namespace Tools
{
    public class Health
    {
        private Unit _unit;
        private Tilemap _tilemap;

        public Health(Unit unit)
        {
            _unit = unit;
        }

        public Health(Unit unit, Tilemap tilemap)
        {
            _unit = unit;
            _tilemap = tilemap;
        }

        public void TakeDamageTank(int damage)
        {
            _unit.health -= damage;

            if (_unit.health <= 0)
            {
                DeadTank();
            }
        }

        public void TakeDamageEnviroment(Vector3Int tilePosition)
        {
            DeadEnviroment(tilePosition);
        }

        private void DeadEnviroment(Vector3Int tilePosition)
        {
            _tilemap.SetTile(tilePosition, null);
        }

        private void DeadTank()
        {
            if (_unit.gameObject.TryGetComponent(out Player player))
            {
                player.Dead();
            }
            Object.Destroy(_unit.gameObject);
        }
    }
}