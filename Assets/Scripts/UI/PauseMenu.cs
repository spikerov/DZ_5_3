using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private ButtonClickSound _buttonClickSound;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnButtonClickMainMenu()
    {
        _buttonClickSound.PlayButtonClickSound();
        SceneManager.LoadScene(0);
    }

    public void OnButtonClickPauseMenu()
    {
        _buttonClickSound.PlayButtonClickSound();
        _panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnButtonClickPlay()
    {
        _buttonClickSound.PlayButtonClickSound();
        _panelPause.SetActive(false);
        Time.timeScale = 1;
    }
}
