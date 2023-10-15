using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : UnitController
{
    [SerializeField] private TankMovement _tankMovement;

    private Vector2 _direction = new Vector2(0, 1);

    private void Update()
    {
        _tankMovement.Move(_direction);
        _weapon.Attack();
    }

    private void OnTriggerEnter2D(Collision2D other)
    {
        RaycastHit2D checkMoveUp = Physics2D.Raycast(transform.position + Vector3.one, Vector2.up, 0.5f);
        if(!checkMoveUp)
        {
            _direction = new Vector2(0, 1);
            print("up");
            return;
        }

        RaycastHit2D checkMoveRight = Physics2D.Raycast(transform.position + Vector3.one, Vector2.right, 0.5f);
        if(!checkMoveRight)
        {
            _direction = new Vector2(-1, 0);
            print("right");
            return;
        }

        RaycastHit2D checkMoveDown = Physics2D.Raycast(transform.position + Vector3.one, Vector2.down, 0.5f);
        if(!checkMoveDown)
        {
            _direction = new Vector2(0, -1);
            print("down");
            return;
        }

        RaycastHit2D checkMoveLeft = Physics2D.Raycast(transform.position + Vector3.one, Vector2.left, 0.5f);
        if(!checkMoveLeft)
        {
            _direction = new Vector2(-1, 0);
            print("left");
            return;
        }
    }
}