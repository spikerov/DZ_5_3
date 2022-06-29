using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCloseNextLevel : MonoBehaviour
{
    [SerializeField] private ColectedObject _colectedObject;

    private Animator _animator;

    private const string _moveLogsAnimation = "MoveLogs";
    private const string _wallAnimation = "Wall2";
    private const string _wall2Animation = "Wall3";


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
                _animator.SetTrigger(_moveLogsAnimation);
                break;
           case 2:
                _animator.SetTrigger(_wallAnimation);
                break;
            case 3:
                _animator.SetTrigger(_wall2Animation);
                break;
        }
    }


}
