using UnityEngine;

public class Player : PersistentSingleton<Player>
{
    [SerializeField] private PlayerMovement _playerMovement;

    public void Initialize()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    public void setDirectionMove(float direction)
    {
        _playerMovement.Move(direction);
    }
    
    public void setDirectionRotation(float direction)
    {
        _playerMovement.Rotation(direction);
    }    

    public void setDirectionRotationTurret(float direction)
    {
        _playerMovement.RotationTurret(direction);
    }
}
