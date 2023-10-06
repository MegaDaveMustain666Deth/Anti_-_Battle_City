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
}
