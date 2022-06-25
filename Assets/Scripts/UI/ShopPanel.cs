using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panelShop;
    [SerializeField] private ButtonClickSound _buttonClickSound;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnButtonClickShop()
    {
        _buttonClickSound.PlayButtonClickSound();
        _panelShop.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseShopPanel()
    {
        _buttonClickSound.PlayButtonClickSound();
        _panelShop.SetActive(false);
        Time.timeScale = 1;
    }
}
