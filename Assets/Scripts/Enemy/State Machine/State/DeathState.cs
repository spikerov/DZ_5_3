using UnityEngine;

public class DeathState : State
{
    [SerializeField] private Animator _animator;

    private Enemy _enemy;

    private const string _deathAnimation = "Death";

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _animator.Play(_deathAnimation);
        _enemy.TurnOffSounds();
    }
}
