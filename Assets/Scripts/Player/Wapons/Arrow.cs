using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Arrow : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private PlayerMover _mover;
    
    private Vector2 _directionShoot;

    private void Update()
    {
        /*if (_mover.Direction > 0)
            _directionShoot = Vector2.right;
        else
            _directionShoot = Vector2.left;*/

        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.World);
    }
}
