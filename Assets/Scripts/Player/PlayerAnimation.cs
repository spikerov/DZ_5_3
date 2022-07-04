using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private int _stopMovement = 0;
    private const string _jump = "IsGround";
    private const string _move = "MoveSpeed";
    private const string _bow = "IsBow";
    private const string _hit = "Hit";

    public void Jump(bool _isGrounded)
    {
        _animator.SetBool(_jump, _isGrounded);
    }

    public void Move(float Speed, float direction)
    {
        if (direction > _stopMovement || direction < _stopMovement)
            _animator.SetFloat(_move, Speed);
        else
            _animator.SetFloat(_move, _stopMovement);
    }

    public void Attack(Player player)
    {
        if (player.CurrentWeapon.GetComponentInChildren<Bow>())
            _animator.SetTrigger(_bow);
        else
            _animator.SetTrigger(_hit);
    }
}
