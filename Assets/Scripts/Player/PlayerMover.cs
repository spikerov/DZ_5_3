using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private int _extraJumps;
    [SerializeField] private float _checkRaiusForJump;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private Player _player;
    [SerializeField] private Animator _animator;
    [SerializeField] private LayerMask _whatIsGround;

    private PlayerInput _input;
    private Rigidbody2D _rigidbody;
    private float _direction;
    private bool _isGrounded;
    private int _jumpCount;
    private int _directionLeft = 180;
    private int _directionRight = 0;
    private const string _move = "MoveSpeed";
    private const string _jump = "IsGround";
    private const string _bow = "IsBow";
    private const string _hit = "Hit";

    public float Direction => _direction;

    private void Awake()
    {
        _input = new PlayerInput();
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();

        _input.Player.Jump.performed += ctx => OnJump();
        _input.Player.Attack.performed += ctx => OnAttack();

        _jumpCount = _extraJumps;
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Update()
    {
        _direction = _input.Player.Move.ReadValue<float>();
        OnMove(_walkSpeed, _direction);


        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _checkRaiusForJump, _whatIsGround);

        if (_isGrounded == false)
            _animator.SetBool(_jump, false);
        else
            _animator.SetBool(_jump, true);
    }

    private void OnJump()
    {
        if (_isGrounded == true)
            _jumpCount = _extraJumps;

        if (_jumpCount > 0)
        {
            _rigidbody.velocity = Vector2.up * _jumpForce;
            _jumpCount--;
        }
    }

    private void OnMove(float Speed, float direction )
    {
        if (direction == 1)
            transform.rotation = Quaternion.Euler(0, _directionRight, 0);
        else if (direction == -1)
            transform.rotation = Quaternion.Euler(0, _directionLeft, 0);

        if (_input.Player.Run.IsPressed())
        {
            Speed = _runSpeed;
        }

        _rigidbody.velocity = new Vector2(direction * Speed, _rigidbody.velocity.y);

        if (direction > 0 || direction < 0)
            _animator.SetFloat(_move, Speed);
        else
            _animator.SetFloat(_move, 0);
    }

    public void OnAttack()
    {
        if (_player.CurrentWeapon.GetComponentInChildren<Bow>())
        {
            _animator.SetTrigger(_bow);
            _player.CurrentWeapon.Shoot(_player.ShootPoint);
        }
        else
            _animator.SetTrigger(_hit);
    }
}
