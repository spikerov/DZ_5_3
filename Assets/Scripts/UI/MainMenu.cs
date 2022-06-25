using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panelMainMenu;
    [SerializeField] private GameObject _panelInfo;
    [SerializeField] private GameObject _panelSettings;
    [SerializeField] private AudioSource _audioSourceClickButtonSound;
    [SerializeField] private Button _buttonSwitchSound;
    [SerializeField] private Button _buttonSwitchSoundInSettring;
    
    private ChangeSpriteButtonSound _changeButtonSprite;

    private bool _isSoundOn;

    private void Start()
    {
        _isSoundOn = true;
        _audioSourceClickButtonSound.Stop();
    }

    public void OnButtonClickPlay()
    {
        _audioSourceClickButtonSound.Play();
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
            _audioSourceClickButtonSound.Play();
            AudioListener.volume = 1f;
            _isSoundOn = true;
            ChangeButtonSprite();
            _changeButtonSprite.ChangeSpriteInOnSound();
        }
        else
        {
            _audioSourceClickButtonSound.Play();
            AudioListener.volume = 0f;
            _isSoundOn = false;
            ChangeButtonSprite();
            _changeButtonSprite.ChangeSpriteInOffSound();
        }
    }

    public void OnButtonClickSettings()
    {
        _audioSourceClickButtonSound.Play();
        _panelMainMenu.SetActive(false);
        _panelSettings.SetActive(true);
    }

    public void OnButtonClickInfo()
    {
        _audioSourceClickButtonSound.Play();
        _panelMainMenu.SetActive(false);
        _panelInfo.SetActive(true);
    }

    public void OnButtonClickExit()
    {
        _audioSourceClickButtonSound.Play();
        Application.Quit();
    }

    public void OnButtonClickBackMenu()
    {
        _audioSourceClickButtonSound.Play();
        _panelSettings.SetActive(false);
        _panelInfo.SetActive(false);
        _panelMainMenu.SetActive(true);
    }
}
