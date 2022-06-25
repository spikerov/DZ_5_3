using UnityEngine;
using UnityEngine.Events;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;

    [SerializeField] private Player _target;

    public Player Target => _target;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            _target.OnEnemyDied(_reward);
            Destroy(gameObject);
        }
    }
}
