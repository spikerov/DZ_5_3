using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    public override void Shoot(Transform ShootPoint)
    {
        Instantiate(Arrow, ShootPoint.position, Quaternion.identity);
    }
}
