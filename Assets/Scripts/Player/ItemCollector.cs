using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private CanvasLevel _canvasLevel;

    private int _collectedObjectsCount;

    public void SwitchCollectObject(string objectLabel)
    {
        switch (objectLabel)
        {
            case "Mushroom":
                _collectedObjectsCount++;
                _canvasLevel.DisplayPlayerAchievement(objectLabel, _collectedObjectsCount);
                break;
            case "Ruby":
                _collectedObjectsCount++;
                _canvasLevel.DisplayPlayerAchievement(objectLabel, _collectedObjectsCount);
                break;
            case "Agaric":
                _collectedObjectsCount++;
                _canvasLevel.DisplayPlayerAchievement(objectLabel, _collectedObjectsCount);
                break;
            default:
                Debug.Log("Object name is incorrect");
                break;
        }
    }
}
