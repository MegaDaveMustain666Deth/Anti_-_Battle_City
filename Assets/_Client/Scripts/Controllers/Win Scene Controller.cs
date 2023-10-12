using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class WinSceneController : MonoBehaviour
{
    private UIDocument _doc;

    private void Awake()
    {
        _doc = GetComponent<UIDocument>();
        Button _nextButton = _doc.rootVisualElement.Q<Button>("NextLevel");
        Button _menuButton = _doc.rootVisualElement.Q<Button>("ToMenu");

        _nextButton.clicked += OpenLevel;
        _menuButton.clicked += OpenMenu;
    }

    private void OpenLevel()
    {
        DataSave.Save save = new DataSave.Save();

        int company = save.GetCompany();
        int level = save.GetLevel();

        SceneManager.LoadScene(company + "level" + level);
    }

    private void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
}
