using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    private Enemy _enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            _enemy = enemy;
            Attack();
        }
    }

    public override void Attack()
    {
        if (_enemy != null)
            _enemy.TakeDamage(_damage);
    }
}
