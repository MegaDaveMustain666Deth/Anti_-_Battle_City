using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _rotationSpeedTurret;
    [SerializeField] private GameObject _turret;

    public void Move(float direction)
    {
        transform.Translate(new Vector2(0, direction) * _speed * Time.deltaTime);
    }

    public void Rotation(float direction)
    {
        Quaternion rotation = transform.rotation;
        float zRotate = (direction * Time.deltaTime * _rotationSpeed) + rotation.eulerAngles.z;
        rotation = Quaternion.Euler(0, 0, zRotate);
        transform.rotation = rotation;
    }

    public void RotationTurret(float direction)
    {
        Quaternion rotation = _turret.transform.rotation;
        float zRotate = (direction * Time.deltaTime * _rotationSpeedTurret) + rotation.eulerAngles.z;
        rotation = Quaternion.Euler(0, 0, zRotate);
        _turret.transform.rotation = rotation;
    }
}