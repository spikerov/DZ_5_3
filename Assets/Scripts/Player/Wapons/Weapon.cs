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

    public abstract void Attack();

    public void Buy()
    {
        _isBuyed = true;
    }
}
