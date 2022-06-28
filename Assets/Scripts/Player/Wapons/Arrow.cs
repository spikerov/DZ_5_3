using UnityEngine;

public abstract class Arrow : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private float _visibilityDistance;
    
    private Player _player;
    private PlayerMover _playerMover;
    private Vector2 _directionShot;


    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        _playerMover = _player.GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (_playerMover.Direction == 1)
            _directionShot = Vector2.right;
        else
            _directionShot = Vector2.left;

        transform.Translate(_directionShot * _speed * Time.deltaTime, Space.World);

        if (transform.position.x > _player.transform.position.x + _visibilityDistance || transform.position.x < _player.transform.position.x - _visibilityDistance)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
