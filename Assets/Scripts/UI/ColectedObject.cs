using UnityEngine;

public class ColectedObject : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ObgectNotCollected()
    {
        _animator.SetTrigger("TouchWall");
    }
}
