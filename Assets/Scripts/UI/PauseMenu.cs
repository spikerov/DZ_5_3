using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private ManagerSounds _managerSounds;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnButtonClickMainMenu()
    {
        _managerSounds.OnButtonClickSound();
        SceneManager.LoadScene(0);
    }

    public void OnButtonClickPlay()
    {
        _managerSounds.OnButtonClickSound();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
