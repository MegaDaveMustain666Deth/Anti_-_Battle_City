using UnityEngine;
using UnityEngine.SceneManagement;
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

    [SerializeField] protected TankMovement _playerMovement;

    public void SetDirectionMove(Vector2 direction)
    {
        _playerMovement?.Move(direction);
    }

    public void SetSoundRunning()
    {
        _unitSounds.SoundRunning();
    }

    public void StartMoving(float direction)
    {
        _unitSounds.SoundMoving();
        _playerMovement.RotationMove(direction);
    }

    public void StartRotation(float direction)
    {
        _unitSounds.SoundMoving();
        _playerMovement.Rotation(direction);
    }

    public void Shoot()
    {
        _weapon.Attack();
    }

    public void Dead()
    {
        SceneManager.LoadScene(0);
    }
}