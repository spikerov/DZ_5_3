using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private ManagerSounds _managerSounds;

    public void OnButtonClickMainMenu()
    {
        _managerSounds.OnButtonClickSound();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
