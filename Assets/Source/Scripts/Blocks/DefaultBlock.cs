using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBlock : Block
{
    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        bullet.Hit();
    }
}
