using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private bool _isBuyed = true;
    [SerializeField] private Sprite _icon;
    [SerializeField] protected Arrow Arrow;

    public bool IsBuyed => _isBuyed;

    public abstract void Shoot(Transform ShootPoint);
}
