using UnityEngine;
using TMPro;

public class CanvasLevel : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _collectedObjectsText;
    [SerializeField] private TMP_Text _collectObjectsText;
    [SerializeField] private ObjectsToLift _objectsToLift;
    [SerializeField] private WallCloseNextLevel _wallCloseNextLevel;
    [SerializeField] private int _collectObjectsCount;

    private int _collectedObjectsCount;

    private void Start()
    {
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
