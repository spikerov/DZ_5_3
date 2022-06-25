using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panelDead;
    [SerializeField] private ButtonClickSound _buttonClickSound;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void OnButtonClickMainMenu()
    {
        _buttonClickSound.PlayButtonClickSound();
        SceneManager.LoadScene(0);
    }

    public void OnButtonClickRestartLevel()
    {
        _buttonClickSound.PlayButtonClickSound();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
