using UnityEngine;

public abstract class Arrow : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private float _visibilityDistance;
    
    private Player _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.World);

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
