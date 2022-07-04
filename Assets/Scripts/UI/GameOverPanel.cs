using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private SelectionSoundUI _selectionSoundUI;

    public void OnButtonClickMainMenu()
    {
        _selectionSoundUI.OnButtonClickSound();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
