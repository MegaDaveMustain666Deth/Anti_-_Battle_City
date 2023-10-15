using UnityEngine;

public class TankMovement : MonoBehaviour 
{
    [SerializeField] private float _speed;

    public void Move(Vector2 direction)
    {
        Rotation(direction.x);
        RotationMove(direction.y);
        transform.position += new Vector3(-direction.x * _speed * Time.deltaTime, direction.y * _speed * Time.deltaTime, 0);
    } 

    public void Rotation(float direction)
    {
        if (direction == 1)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 90);
            transform.rotation = rot;
        }
        else if (direction == -1) 
        {
            Quaternion rot = Quaternion.Euler(0, 0, -90);
            transform.rotation = rot;
        }
    }
    public void RotationMove(float direction)
    {
        if (direction == 1)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 0);
            transform.rotation = rot;
        }
        else if (direction == -1)
        {
            Quaternion rot = Quaternion.Euler(0, 0, 180);
            transform.rotation = rot;
        }
    }
}