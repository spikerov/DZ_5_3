using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    [SerializeField] private ManagerSounds _managerSounds;

    public void OnButtonClickMainMenu()
    {
        _managerSounds.OnButtonClickSound();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnButtonClickRestartLevel()
    {
        _managerSounds.OnButtonClickSound();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
