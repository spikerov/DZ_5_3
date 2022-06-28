using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private ManagerPanels _managerPanels;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _managerPanels.OnDeadPanel();
            Time.timeScale = 0;
            player.Die();
        }
    }
}
