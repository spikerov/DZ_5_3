using UnityEngine;

public class MoveState : State
{
    [SerializeField] private Transform _leftPoint;
    [SerializeField] private Transform _rightPoint;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;

    private int _rotationkLeft = 0;
    private int _rotationRight = 180;
    private Transform _currentPoint; 
    private Enemy _enemy;

    private const string _walkAnimation = "Walk";

    private void Start()
    {
        _currentPoint = _leftPoint;
        _enemy = GetComponent<Enemy>();
        _enemy.OnWalkSound();
    }

    private void Update()
    {
        if (_currentPoint == _leftPoint)
            WalkToPoint(_currentPoint);
        else if (_currentPoint == _rightPoint)
            WalkToPoint(_currentPoint);

        if (transform.position.x == _rightPoint.position.x)
            _currentPoint = _leftPoint;
        else if (transform.position == _leftPoint.position)
            _currentPoint = _rightPoint;
    }

    private void WalkToPoint(Transform currentPoint)
    {
        if (transform.position.x < currentPoint.position.x)
            transform.rotation = Quaternion.Euler(0, _rotationRight, 0);
        else
            transform.rotation = Quaternion.Euler(0, _rotationkLeft, 0);

        transform.position = Vector3.MoveTowards(transform.position, currentPoint.position, _speed * Time.deltaTime);
        _animator.Play(_walkAnimation);
    }
}
