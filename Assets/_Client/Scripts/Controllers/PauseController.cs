using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseController : MonoBehaviour
{
    private UIDocument _doc;

    private VisualElement _conteyner;
    private VisualElement _conteynerButtons;
    private VisualElement _pause;
    private VisualElement _settings;

    [SerializeField] private VisualTreeAsset Settings;

    private void Awake()
    {
        _doc = GetComponent<UIDocument>();

        _conteyner = _doc.rootVisualElement.Q<VisualElement>("ContainerAll");
        _conteynerButtons = _doc.rootVisualElement.Q<VisualElement>("Fon");

        _pause = _conteynerButtons.Q<VisualElement>("Pause");
        _settings = Settings.CloneTree();



        _conteyner.Clear();
        _conteynerButtons.Clear();
    }

    public void OnPause()
    {
        _conteyner.Clear();
        _conteynerButtons.Clear();
        _conteyner.Add(_conteynerButtons);
        _conteynerButtons.Add(_pause);
        Time.timeScale = 0;

        Button continion = _conteyner.Q<Button>("ButtonContinue");
        Button settings = _conteyner.Q<Button>("ButtonSettings");
        Button toMenu = _conteyner.Q<Button>("ButtonGoToMenu");

        continion.clicked += Continue;
        settings.clicked += OpenSettings;
        toMenu.clicked += GoToMenu;

    }
    private void Continue()
    {
        _conteyner.Clear();
        Time.timeScale = 1;
    }
    private void OpenSettings()
    {
        _conteynerButtons.Clear();
        _conteynerButtons.Add(_settings);

        Slider volume = _conteyner.Q<Slider>("Volume");
        Button backButton = _conteyner.Q<Button>("BackButton");

        backButton.clicked += OnPause;

    }
    private void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
