using UnityEngine;

public class DeathState : State
{
    [SerializeField] private Animator _animator;

    private Enemy _enemy;


    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _animator.Play("Death");
        _enemy.TurnOffSounds();
    }
}
