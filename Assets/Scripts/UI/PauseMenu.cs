using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private SelectionSoundUI _selectionSoundUI;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnButtonClickMainMenu()
    {
        _selectionSoundUI.OnButtonClickSound();
        SceneManager.LoadScene(0);
    }

    public void OnButtonClickPlay()
    {
        _selectionSoundUI.OnButtonClickSound();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
