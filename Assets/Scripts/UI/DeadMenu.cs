using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    [SerializeField] private SelectionSoundUI _selectionSoundUI;

    public void OnButtonClickMainMenu()
    {
        _selectionSoundUI.OnButtonClickSound();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnButtonClickRestartLevel()
    {
        _selectionSoundUI.OnButtonClickSound();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
