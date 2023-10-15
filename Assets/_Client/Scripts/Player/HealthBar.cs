using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _FillingImage;

    private void OnEnable()
    {
        Player.ChangeHP += UpdateCurrentHP;
    }

    private void UpdateCurrentHP()
    {
        _FillingImage.fillAmount = Player.Instance.GetHP()/100f;
    }
}
