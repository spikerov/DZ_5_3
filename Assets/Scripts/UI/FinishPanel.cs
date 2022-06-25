using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPanel : MonoBehaviour
{
    [SerializeField] private int _numberNextLevel;
    [SerializeField] private GameObject _finishPanel;
    [SerializeField] private ButtonClickSound _buttonClickSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _finishPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnButtonClickMainMenu()
    {
        _buttonClickSound.PlayButtonClickSound();
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OnButtonClickNextLevel()
    {
        _buttonClickSound.PlayButtonClickSound();
        SceneManager.LoadScene(_numberNextLevel);
    }
}
