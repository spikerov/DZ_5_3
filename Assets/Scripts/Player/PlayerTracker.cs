using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _xoffSet;

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x - _xoffSet, transform.position.y, transform.position.z);
    }
}
