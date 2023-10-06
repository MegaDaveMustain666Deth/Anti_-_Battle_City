using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private void Start()
    {
        InputManager.Instance.Initialize();
        Player.Instance.Initialize();
    }
}
