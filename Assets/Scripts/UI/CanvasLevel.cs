using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CanvasLevel : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _collectedObjectsText;
    [SerializeField] private TMP_Text _collectObjectsText;
    [SerializeField] private ObjectsToLift _collectObject;
    [SerializeField] private WallCloseNextLevel _wallCloseNextLevel;
    [SerializeField] private int _collectObjectsCount;
    [SerializeField] private ManagerSounds _managerSounds;

    private int _collectedObjectsCount;

    private void Start()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                _managerSounds.OnLevel1Music();
                break;
            case 2:
                _managerSounds.OnLevel2Music();
                break;
            case 3:
                _managerSounds.OnLevel3Music();
                break;
        }

        _collectObjectsText.text = _collectObjectsCount.ToString();
    }

    public void AddCoin(int CoinCount)
    {
        DisplayPlayerAchievement("Coin", CoinCount);
    }

    public void DisplayPlayerAchievement(string objectLabel, int count)
    {
        switch (objectLabel)
        {
            case "Coin":
                _coinsText.text = count.ToString();
                break;
            case "Mushroom":
                _collectedObjectsText.text = count.ToString();
                _collectedObjectsCount = count;
                break;
            case "Ruby":
                _collectedObjectsText.text = count.ToString();
                _collectedObjectsCount = count;
                break;
            case "Agaric":
                _collectedObjectsText.text = count.ToString();
                _collectedObjectsCount = count;
                break;
            default:
                Debug.Log("Object name is incorrect");
                break;
        }

        if (_collectedObjectsCount >= _collectObjectsCount)
            OpenNextLevel();
    }

    private void OpenNextLevel()
    {
        _wallCloseNextLevel.OpenNextLevel();
    }
}
