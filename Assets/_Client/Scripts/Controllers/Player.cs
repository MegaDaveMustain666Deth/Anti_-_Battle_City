using UnityEngine;
using System;

public class Player : UnitController
{
    public static Player Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] protected PlayerMovement _playerMovement;

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

    public void Shoot()
    {
        _weapon.Attack();
    }
}
