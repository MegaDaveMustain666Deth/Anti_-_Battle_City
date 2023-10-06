using UnityEngine;

public class InputManager : PersistentSingleton<InputManager>
{
    [SerializeField] private PlayerInput _playerInput;

    public void Initialize()
    {
        _playerInput = new PlayerInput();
        OnEnable();
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
        Player.Instance.setDirectionMove(_playerInput.Player.Move.ReadValue<float>());
        Player.Instance.setDirectionRotation(_playerInput.Player.Rotation.ReadValue<float>());
        Player.Instance.setDirectionRotationTurret(_playerInput.Player.RotationTower.ReadValue<float>());
    }
}