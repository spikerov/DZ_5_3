using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    [SerializeField] private ManagerSounds _managerSounds;

    public void CloseShopPanel()
    {
        _managerSounds.OnButtonClickSound();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
