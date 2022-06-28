using System;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private bool _isBuyed = true;
    [SerializeField] private Sprite _icon;
    [SerializeField] protected int _damage;

    // public bool IsAttack = true;

    public string Label => _label;
    public int Price => _price;
    public bool IsBuyed => _isBuyed;
    public Sprite Icon => _icon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
        }
    }

    public void Buy()
    {
        _isBuyed = true;
    }
}
