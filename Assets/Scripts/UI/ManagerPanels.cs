using UnityEngine;

public class ManagerPanels : MonoBehaviour
{
    [SerializeField] private GameObject _panelMainMenu;
    [SerializeField] private GameObject _panelLevels;
    [SerializeField] private GameObject _panelSettings;
    [SerializeField] private GameObject _panelInfo;
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _panelShop;
    [SerializeField] private GameObject _panelDead;
    [SerializeField] private GameObject _panelFinish;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private ManagerSounds _managerSounds;

    public void OnButtonClickPauseMenu()
    {
        _managerSounds.OnButtonClickSound();
        _panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnButtonClickShop()
    {
        _managerSounds.OnButtonClickSound();
        _panelShop.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnNextLevelZone()
    {
        _panelFinish.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnDeadPanel()
    {
        _panelDead.SetActive(true);
        Time.timeScale = 0;
    }

    public void OpenGameOverPanel()
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnButtonClickLevels()
    {
        _managerSounds.OnButtonClickSound();
        _panelLevels.SetActive(true);
    }

    public void OnButtonClickBackMainMenu()
    {
        _managerSounds.OnButtonClickSound();
        _panelLevels.SetActive(false);
        _panelSettings.SetActive(false);
        _panelInfo.SetActive(false);
        _panelMainMenu.SetActive(true);
    }
}
