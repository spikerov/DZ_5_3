using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class WeapnView : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private Image _icon;
    [SerializeField] private Button _sellButtoncon;

    private Weapon _weapon;

    public event UnityAction<Weapon, WeapnView> SellButtonClick;

    private void OnEnable()
    {
        _sellButtoncon.onClick.AddListener(OnSellButtonClick);
        _sellButtoncon.onClick.AddListener(TryLockItem);
    }

    private void OnDisable()
    {
        _sellButtoncon.onClick.RemoveListener(OnSellButtonClick);
        _sellButtoncon.onClick.RemoveListener(TryLockItem);
    }

    private void TryLockItem()
    {
        if (_weapon.IsBuyed)
            _sellButtoncon.interactable = false;
    }

    public void Render(Weapon weapon)
    {
        _weapon = weapon;
        _label.text = _weapon.Label;
        _price.text = _weapon.Price.ToString();
        _icon.sprite = _weapon.Icon;
    }

    private void OnSellButtonClick()
    {
        SellButtonClick?.Invoke(_weapon, this);
    }
}
