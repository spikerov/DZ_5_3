using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPanel : MonoBehaviour
{
    [SerializeField] private SelectionSoundUI _selectionSoundUI;
    [SerializeField] private ManagerPanels _managerPanels;

    public void OnButtonClickMainMenu()
    {
        _selectionSoundUI.OnButtonClickSound();
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OnButtonClickNextLevel()
    {
        _selectionSoundUI.OnButtonClickSound();
        if (SceneManager.GetActiveScene().buildIndex <= 3)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            _managerPanels.OpenGameOverPanel();

        Time.timeScale = 1;
    }
}

