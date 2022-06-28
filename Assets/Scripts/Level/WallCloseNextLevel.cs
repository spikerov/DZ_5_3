using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCloseNextLevel : MonoBehaviour
{
    [SerializeField] private ColectedObject _colectedObject;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _colectedObject.ObgectNotCollected();
        }
    }

    public void OpenNextLevel()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                _animator.SetTrigger("MoveLogs");
                break;
           case 2:
                _animator.SetTrigger("Wall2");
                break;
            case 3:
                _animator.SetTrigger("Wall3");
                break;
        }
    }


}
