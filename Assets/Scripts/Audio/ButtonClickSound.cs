using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourceClickButtonSound;

    private void Start()
    {
        Time.timeScale = 1;
        _audioSourceClickButtonSound.Stop();
    }

    public void PlayButtonClickSound()
    {
        _audioSourceClickButtonSound.Play();
    }

}
