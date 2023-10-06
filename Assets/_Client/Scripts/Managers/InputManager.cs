using UnityEngine;

public class InputManager : PersistentSingleton<InputManager>
{
    [SerializeField] private PlayerInput _playerInput;
    public float d;

    public void Initialize()
    {
        _playerInput = new PlayerInput();
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
        d = _playerInput.Player.Move.ReadValue<float>();
        Player.Instance.setDirectionMove(_playerInput.Player.Move.ReadValue<float>());
    }
}