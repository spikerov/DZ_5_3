using UnityEngine;

public class ManagerSounds : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private AudioSource _getCoin;
    [SerializeField] private AudioSource _pickUpObject;
    [SerializeField] private AudioSource _mainMenuMusic;
    [SerializeField] private AudioSource _level1Music;
    [SerializeField] private AudioSource _level2Music;
    [SerializeField] private AudioSource _level3Music;
    [SerializeField] private AudioSource _playerWalkSound;
    [SerializeField] private AudioSource _playerRunSound;
    [SerializeField] private AudioSource _hedgehogWalk;
    [SerializeField] private AudioSource _hedgehogAttack;
    [SerializeField] private AudioSource _boarWalk;
    [SerializeField] private AudioSource _boarAttack;
    [SerializeField] private AudioSource _foxgWalk;
    [SerializeField] private AudioSource _foxAttack;
    [SerializeField] private AudioSource _skeletonWalk;
    [SerializeField] private AudioSource _skeletonAttack;
    [SerializeField] private AudioSource _zombieWalk;
    [SerializeField] private AudioSource _zombieAttack;

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

    public void OnPlayerWalkSound()
    {
        _playerWalkSound.Play();
    }

    public void OnPlayerRunSound()
    {
        _playerRunSound.Play();
    }

    public void OnHedgehogWalkSound()
    {
        _hedgehogWalk.Play();
    }

    public void OnHedgehogAttackSound()
    {
        _hedgehogAttack.Play();
    }

    public void OnBoarWalkSound()
    {
        _boarWalk.Play();
    }

    public void OnBoarAttackSound()
    {
        _boarAttack.Play();
    }

    public void OnFoxWalkSound()
    {
        _foxgWalk.Play();
    }

    public void OnFoxAttackSound()
    {
        _foxAttack.Play();
    }

    public void OnSkeletonWalkSound()
    {
        _skeletonWalk.Play();
    }

    public void OnSkeletonAttackSound()
    {
        _skeletonAttack.Play();
    }

    public void OnZombieWalkSound()
    {
        _zombieWalk.Play();
    }

    public void OnZombieAttackSound()
    {
        _zombieAttack.Play();
    }

}
