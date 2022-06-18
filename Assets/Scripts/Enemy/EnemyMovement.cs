using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    [SerializeField] private int _walkRight = 180;

    private Transform[] _points;
    private int _currentPoint;
    private int _leftPoint = 0;
    private int _rightPoint = 1;


    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = _leftPoint;
            }
        }

        if (_currentPoint == _rightPoint)
            transform.rotation = Quaternion.Euler(0, _walkRight, 0);
        else
            transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
