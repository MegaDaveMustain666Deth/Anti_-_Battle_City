using UnityEngine;
using System;

public class Player : PersistentSingleton<Player>
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerSounds _playerSounds;

    public event Action OnMove;
    public event Action OnShoot;
    
    public void Initialize()
    {
        _playerSounds.Initialize();
    }

    public void setDirectionMove(float direction)
    {
        _playerMovement.Move(direction);
        OnMove.Invoke();
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
