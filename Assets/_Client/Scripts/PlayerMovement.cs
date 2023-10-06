using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField] private float _speed;

    public void Move(float direction)
    {
        transform.Translate(new Vector2(0, direction) * _speed * Time.deltaTime);
    }
}