using UnityEngine;

public class Bow : Weapon
{
    public override void Shoot(Transform ShootPoint)
    {
        Instantiate(Arrow, ShootPoint.position, Quaternion.identity);
    }
}
