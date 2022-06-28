using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;
    [SerializeField] private Player _target;
    [SerializeField] protected AudioSource _walkSound;
    [SerializeField] protected AudioSource _angrySound;

    public Player Target => _target;
    public int Health => _health;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        /*if (damage > 0)
            StartCoroutine(OnDemage());*/

        if (_health <= 0)
        {
            _target.OnEnemyDied(_reward);
            Destroy(gameObject, 4);
        }
    }

    /*private IEnumerator OnDemage()
    {

    }*/

    public abstract void OnWalkSound();

    public abstract void OnAttackSound();

    public abstract void TurnOffSounds();
}
