using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : UnitController
{
    [SerializeField] private TankMovement _tankMovement;

    private Vector2 _direction = new Vector2(0, 1);

    private bool l;
    private void Update()
    {
        _tankMovement.Move(_direction);
        _weapon.Attack();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + Vector3.one, Vector2.up, 0.5f);
        if(hit)
        {
            _direction = new Vector2(0, -1);
        }
        hit = Physics2D.Raycast(transform.position + Vector3.one, Vector2.left, 0.5f);
        if(hit)
        {
            _direction = new Vector2(1, 0);
        }
        hit = Physics2D.Raycast(transform.position + Vector3.one, Vector2.down, 0.5f);
        if(hit)
        {
            _direction = new Vector2(0, 1);
        }
        hit = Physics2D.Raycast(transform.position + Vector3.one, Vector2.right, 0.5f);
        if(hit)
        {
            _direction = new Vector2(-1, 0);
        }
        //_direction = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
    }
}