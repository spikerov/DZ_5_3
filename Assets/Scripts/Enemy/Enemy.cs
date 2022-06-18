using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }
}
