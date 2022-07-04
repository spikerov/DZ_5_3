using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panelMainMenu;
    [SerializeField] private GameObject _panelInfo;
    [SerializeField] private GameObject _panelSettings;
    [SerializeField] private Button _buttonSwitchSound;
    [SerializeField] private Button _buttonSwitchSoundInSettring;
    [SerializeField] private SelectionSoundUI _sounds;
    
    private ChangeSpriteButtonSound _changeButtonSprite;

    private bool _isSoundOn;

    private void Start()
    {
        _isSoundOn = true;
        _sounds.OnMainMenuMusic();
    }

    public void OnButtonClickPlay()
    {
        _sounds.OnButtonClickSound();
        SceneManager.LoadScene(1);
    }

    private void ChangeButtonSprite()
    {
        if (_panelMainMenu.active == true)
        {
            _changeButtonSprite = _buttonSwitchSound.GetComponent<ChangeSpriteButtonSound>();
        }
        else if (_panelSettings.active == true)
        {
            _changeButtonSprite = _buttonSwitchSoundInSettring.GetComponent<ChangeSpriteButtonSound>();
        }
    }

    public void OnButtonClickSwitchSound()
    {
        if (_isSoundOn == false)
        {
            _sounds.OnButtonClickSound();
            AudioListener.volume = 1f;
            _isSoundOn = true;
            ChangeButtonSprite();
            _changeButtonSprite.ChangeSpriteInOnSound();
        }
        else
        {
            _sounds.OnButtonClickSound();
            AudioListener.volume = 0f;
            _isSoundOn = false;
            ChangeButtonSprite();
            _changeButtonSprite.ChangeSpriteInOffSound();
        }
    }

    public void OnButtonClickSettings()
    {
        _sounds.OnButtonClickSound();
        _panelMainMenu.SetActive(false);
        _panelSettings.SetActive(true);
    }

    public void OnButtonClickInfo()
    {
        _sounds.OnButtonClickSound();
        _panelMainMenu.SetActive(false);
        _panelInfo.SetActive(true);
    }

    public void OnButtonClickExit()
    {
        _sounds.OnButtonClickSound();
        Application.Quit();
    }

    public void OnButtonClickBackMenu()
    {
        _sounds.OnButtonClickSound();
        _panelSettings.SetActive(false);
        _panelInfo.SetActive(false);
        _panelMainMenu.SetActive(true);
    }
}
