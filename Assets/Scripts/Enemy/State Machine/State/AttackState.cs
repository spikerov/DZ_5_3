using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _dalay;
    [SerializeField] private float _transitionRange;

    private Enemy _enemy;
    private Animator _animator;
    private float _lastAttackTime;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _animator = GetComponent<Animator>();
        _enemy.OnAttackSound();
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) < _transitionRange)
        {
            if (transform.position.x < Target.transform.position.x)
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else
                transform.rotation = Quaternion.Euler(0, 0, 0);

            if (_lastAttackTime <= 0)
            {
                Atack(Target);
                _lastAttackTime = _dalay;
            }

            _lastAttackTime -= Time.deltaTime;
        }
    }

    private void Atack(Player target)
    {
        _animator.Play("Attack");
        target.ApplyDamage(_damage);
    }
}
