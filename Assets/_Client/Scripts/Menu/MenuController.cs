using UnityEngine;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument _doc; // UI Document

    private Button _backButton;

    //case for importing trees
    private VisualElement _conteyner;
    private VisualElement _firstmenu;
    private VisualElement _Settings;
    private VisualElement _CompaniesButtons;
    private VisualElement _currentListLevels;

    [Header("Visuals Tree Assets")] // trees aseets
    [SerializeField] private VisualTreeAsset _CompaniesAsset;
    [SerializeField] private VisualTreeAsset _firstMenuAsset;
    [SerializeField] private VisualTreeAsset _settingsAsset;

    [Header("Levels Panels")] // levels assets
    [SerializeField] private VisualTreeAsset level_1;
    [SerializeField] private VisualTreeAsset level_2;
    [SerializeField] private VisualTreeAsset level_3;

    private void Awake()
    {
        _doc = GetComponent<UIDocument>();

        _conteyner = _doc.rootVisualElement.Q<VisualElement>("interehtable");
        _CompaniesButtons = _CompaniesAsset.CloneTree();
        _firstmenu = _firstMenuAsset.CloneTree();
        _Settings = _settingsAsset.CloneTree();

        OpenFirstMenu();
    }

    private void OpenFirstMenu()
    {
        _conteyner.Clear();
        _conteyner.Add(_firstmenu);// clean/donload

        // buttons import
        Button _startButton = _conteyner.Q<Button>("ButtonPlay");
        Button _settingsButton = _conteyner.Q<Button>("ButtonSettings");
        Button _exitButton = _conteyner.Q<Button>("ButtonExit");

        _startButton.clicked += ShowCompanies;
        _settingsButton.clicked += OpenSettings;
        _exitButton.clicked += Exit;
    }

    private void ShowCompanies()
    {
        _conteyner.Clear();
        _conteyner.Add(_CompaniesButtons); // clean/donload

        // buttons import
        Button Company1 = _conteyner.Q<Button>("Company1");
        Button Company2 = _conteyner.Q<Button>("Company2");
        Button Company3 = _conteyner.Q<Button>("Company3");

        Company1.clicked += () => OpenListLevels(level_1);
        Company2.clicked += () => OpenListLevels(level_2);
        Company3.clicked += () => OpenListLevels(level_3);
    }

    private void OpenListLevels(VisualTreeAsset name)
    {
        _currentListLevels = name.CloneTree(); // receive button clicked
        _conteyner.Clear();
        _conteyner.Add(_currentListLevels); // clean/donload
        _backButton = _conteyner.Q<Button>("BackButton");
        _backButton.clicked += OpenFirstMenu;
    }

    private void OpenSettings()
    {
        _conteyner.Clear();
        _conteyner.Add(_Settings); // clean/donload
        // future settings
        _backButton = _conteyner.Q<Button>("BackButton");// buttons import
        _backButton.clicked += OpenFirstMenu;
    }

    private void Exit()
    {
        Application.Quit();
    }
}
