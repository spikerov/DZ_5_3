using UnityEngine;

public class ColectedObject : MonoBehaviour
{
    private Animator _animator;

    private const string _touchWallAnimation = "TouchWall";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ObgectNotCollected()
    {
        _animator.SetTrigger(_touchWallAnimation);
    }
}
