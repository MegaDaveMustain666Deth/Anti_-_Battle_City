using UnityEngine;

public class InputManager : PersistentSingleton<InputManager>
{
    [SerializeField] private PlayerInput _playerInput;

    public void Initialize()
    {
        _playerInput = new PlayerInput();
        OnEnable();

        AttachPlayer();
    }

    private void AttachPlayer()
    {
        _playerInput.Player.Move.performed += context => Player.Instance.SetSoundMoving();
        _playerInput.Player.Move.canceled += context => Player.Instance.SetSoundRunning();

        _playerInput.Player.Shoot.performed += contxt => Player.Instance.Shoot();
    }

    public void OnEnable()
    {
        _playerInput?.Enable();
    }

    public void OnDisable()
    {
        _playerInput?.Disable();
    }

    private void Update()
    {
        Player.Instance.SetDirectionMove(_playerInput.Player.Move.ReadValue<float>());
        Player.Instance.SetDirectionRotation(_playerInput.Player.Rotation.ReadValue<float>());
        Player.Instance.SetDirectionRotationTurret(_playerInput.Player.RotationTower.ReadValue<float>());
    }
}