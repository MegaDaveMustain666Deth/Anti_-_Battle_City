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
        _playerInput.Player.Shoot.performed += context => Player.Instance.Shoot();
        _playerInput.Player.OnPause.performed += context => FindObjectOfType<PauseController>().OnPause();
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
        Player.Instance?.SetDirectionMove(_playerInput.Player.Move.ReadValue<Vector2>());
    }
}