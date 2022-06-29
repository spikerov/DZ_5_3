using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    [SerializeField] private SelectionSoundUI _selectionSoundUI;

    public void CloseShopPanel()
    {
        _selectionSoundUI.OnButtonClickSound();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
