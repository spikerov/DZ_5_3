using UnityEngine;

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
        _animator.SetTrigger("MoveLogs");
    }


}
