using UnityEngine;

public class InputManager : PersistentSingleton<InputManager>
{
    [SerializeField] private PlayerInput _playerInput;

    public void Initialize()
    {
        _playerInput = new PlayerInput();
        OnEnable();

        AttachPlayer();
        _playerInput.Player.OnPause.performed += context => FindObjectOfType<PauseController>().OnPause();
    }

    private void AttachPlayer()
    {
        _playerInput.Player.Shoot.performed += context => Player.Instance?.Shoot();
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
        if(Player.Instance != null)
        Player.Instance.SetDirectionMove(_playerInput.Player.Move.ReadValue<Vector2>());
    }
}