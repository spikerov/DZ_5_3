using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelZone : MonoBehaviour
{
    [SerializeField] private ManagerPanels _managerPanels;
    [SerializeField] private LevelController _levelController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _levelController.IsEndLevel();
            
            if (SceneManager.GetActiveScene().buildIndex == 3)
                _managerPanels.OpenGameOverPanel();
            else
                _managerPanels.OnNextLevelZone();

            Time.timeScale = 0;
        }
    }
}
