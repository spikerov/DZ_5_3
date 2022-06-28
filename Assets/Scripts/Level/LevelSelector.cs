using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] private ManagerPanels _managerPanels;
    [SerializeField] private ManagerSounds _sounds;
    [SerializeField] private Button[] _buttonSelecLevel;

    private int _reachedLevels;
    private const string _saveLevelKey = "ReachedLevels";

    private void Start()
    {
        _reachedLevels = PlayerPrefs.GetInt(_saveLevelKey, 1);

        for (int i = 0; i < _buttonSelecLevel.Length; i++)
        {
            if (i + 1 > _reachedLevels)
            {
                _buttonSelecLevel[i].interactable = false;
            }
        }
    }

    public void SelectLevel(int levelNumber)
    {
        _sounds.OnButtonClickSound();
        SceneManager.LoadScene(levelNumber);
    }

    public void OnButtonClickBackMenu()
    {
        _managerPanels.OnButtonClickBackMainMenu();
    }

    public void ResetLevelProgress()
    {
        _sounds.OnButtonClickSound();
        PlayerPrefs.DeleteKey(_saveLevelKey);
        _reachedLevels = 1;

        for (int i = 0; i < _buttonSelecLevel.Length; i++)
        {
            if (i + 1 > _reachedLevels)
            {
                _buttonSelecLevel[i].interactable = false;
            }
        }
    }
}
