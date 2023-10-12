using UnityEngine;
using System;

[RequireComponent(typeof(TankUnit))]
[RequireComponent(typeof(UnitHitBox))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class UnitController : MonoBehaviour
{
    [SerializeField] protected PlayerSounds _playerSounds;
    [SerializeField] protected Unit _unit;
    [SerializeField] protected Weapon _weapon;

    public Action OnShoot;
    
    public void Initialize()
    {
        _playerSounds.Initialize();
        _unit.Initialize();
    }
}