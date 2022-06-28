using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPanel : MonoBehaviour
{
    [SerializeField] private ManagerSounds _managerSounds;
    [SerializeField] private ManagerPanels _managerPanels;

    public void OnButtonClickMainMenu()
    {
        _managerSounds.OnButtonClickSound();
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OnButtonClickNextLevel()
    {
        _managerSounds.OnButtonClickSound();
        if (SceneManager.GetActiveScene().buildIndex <= 3)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            _managerPanels.OpenGameOverPanel();

        Time.timeScale = 1;
    }
}

