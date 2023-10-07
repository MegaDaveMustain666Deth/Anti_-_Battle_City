using UnityEngine;
using System;

public class Player : PersistentSingleton<Player>
{

    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerSounds _playerSounds;

    public event Action OnShoot;
    
    public void Initialize()
    {
        _playerSounds.Initialize();
    }

    public void SetDirectionMove(float direction)
    {
        _playerMovement.Move(direction);
    }
    
    public void SetDirectionRotation(float direction)
    {
        _playerMovement.Rotation(direction);
    }    

    public void SetDirectionRotationTurret(float direction)
    {
        _playerMovement.RotationTurret(direction);
    }

    public void SetSoundMoving()
    {
        _playerSounds.SoundMoving();
    }

    public void SetSoundRunning()
    {
        _playerSounds.SoundRunning();
    }
}
