using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Player _player;
    [SerializeField] private WeapnView _template;
    [SerializeField] private GameObject _itemContainer;
    [SerializeField] private GameObject _panelShop;

    private void Start()
    {
        for (int i = 0; i < _weapons.Count; i++)
        {
            AddItem(_weapons[i]);
        }
    }

    private void AddItem(Weapon weapon)
    {
        var view = Instantiate(_template, _itemContainer.transform);
        view.SellButtonClick += OnSellButtonClick;
        view.Render(weapon);
    }

    private void OnSellButtonClick(Weapon weapon, WeapnView view)
    {
        TrySellWeapon(weapon, view);
    }

    private void TrySellWeapon(Weapon weapon, WeapnView view)
    {
        if (weapon.Price <= _player.Coin)
        {
            _player.BuyWeapon(weapon);
            weapon.Buy();
            view.SellButtonClick -= OnSellButtonClick;
        }
    }
}

