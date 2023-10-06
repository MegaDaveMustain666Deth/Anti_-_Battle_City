using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private void Awake()
    {
        InputManager.Instance.Initialize();
        Player.Instance.Initialize();
    }
}
