using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Player))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private int _extraJumps;
    [SerializeField] private float _delayAttack;
    [SerializeField] private float _checkRaiusForJump;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private PlayerAnimation _animations;
    [SerializeField] private AudioSource _jumpSound;
    [SerializeField] private AudioSource _walkSound;
    [SerializeField] private AudioSource _runSound;
    [SerializeField] private Player _player;
    [SerializeField] private Animator _animator;
    [SerializeField] private LayerMask _whatIsGround;

    private PlayerInput _input;
    private Rigidbody2D _rigidbody;
    private float _direction;
    private float _lastAttackTime;
    private bool _isGrounded;
    private int _jumpCount;
    private int _zeroAvailableJumps = 0;
    private int _movementRight = 1;
    private int _movementLeft = -1;
    private int _directionLeft = 180;
    private int _directionRight = 0;

    public float Direction => _direction;

    private void Awake()
    {
        _input = new PlayerInput();
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();

        _input.Player.Jump.performed += ctx => OnJump();
        _input.Player.Attack.performed += ctx => OnAttack();

        _jumpSound.Stop();
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
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _checkRaiusForJump, _whatIsGround);
        OnMove(_walkSpeed, _direction);
        _animations.Jump(_isGrounded);
        _lastAttackTime--;
    }

    private void OnJump()
    {

        if (_isGrounded == true)
        {
            _jumpCount = _extraJumps;
            _jumpSound.Play();
        }

        if (_jumpCount > _zeroAvailableJumps)
        {
            _rigidbody.velocity = Vector2.up * _jumpForce;
            _jumpCount--;
        }
    }

    private void OnMove(float Speed, float direction)
    {
        if (direction == _movementRight)
            transform.rotation = Quaternion.Euler(0, _directionRight, 0);
        else if (direction == _movementLeft)
            transform.rotation = Quaternion.Euler(0, _directionLeft, 0);

        if (_input.Player.Run.IsPressed())
        {
            Speed = _runSpeed;
        }

        _rigidbody.velocity = new Vector2(direction * Speed, _rigidbody.velocity.y);
        _animations.Move(Speed, direction);

        if (_isGrounded == true)
        {
            if (direction == 0)
            {
                _walkSound.Stop();
                _runSound.Stop();
            }
            else
            {
                if (Speed <= _walkSpeed)
                    _walkSound.Play();
                else
                    _runSound.Play();
            }
        }
    }

    public void OnAttack()
    {
        if (_lastAttackTime <= 0 && _isGrounded == true)
        {
            _lastAttackTime = _delayAttack;
            _animations.Attack(_player);
        }
    }
}
