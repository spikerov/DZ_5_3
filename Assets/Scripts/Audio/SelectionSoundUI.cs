using UnityEngine;

public class SelectionSoundUI : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private AudioSource _getCoin;
    [SerializeField] private AudioSource _pickUpObject;
    [SerializeField] private AudioSource _mainMenuMusic;
    [SerializeField] private AudioSource _level1Music;
    [SerializeField] private AudioSource _level2Music;
    [SerializeField] private AudioSource _level3Music;

    public void OnButtonClickSound()
    {
        _buttonClickSound.Play();
    }

    public void OnSoundGetCoin()
    {
        _getCoin.Play();
    }

    public void OnSoundPickUpObject()
    {
        _pickUpObject.Play();
    }

    public void OnMainMenuMusic()
    {
        _mainMenuMusic.Play();
    }

    public void OnLevel1Music()
    {
        _level1Music.Play();
    }

    public void OnLevel2Music()
    {
        _level2Music.Play();
    }

    public void OnLevel3Music()
    {
        _level3Music.Play();
    }
}
