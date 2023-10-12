using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _FillingImage;
    [SerializeField] private TankUnit _tankUnit;
    [SerializeField] private GameObject _healthBar;

    private void Update()
    {
        _FillingImage.fillAmount = _tankUnit.GetHP() / 100;
        float Zrotation = -transform.rotation.z;
        _healthBar.transform.rotation = Quaternion.Euler(0, 0, Zrotation);
    }
}
