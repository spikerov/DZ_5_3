using UnityEngine;
using System;

[Serializable]
public class Bow : Weapon
{
    [SerializeField] private Arrow Arrow;
    [SerializeField] private Transform _shootPoint;

    public void Start()
    {
        Instantiate(Arrow, _shootPoint.position, Quaternion.identity);
    }
}
