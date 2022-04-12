using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RicoshetBlock : BaseBlock
{
    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        Debug.Log(bullet.transform.right);
        Vector2 newDirection = Vector2.Reflect(bullet.transform.right, normal);
        bullet.SetAngle(Mathf.Atan2(newDirection.y, newDirection.x) * Mathf.Rad2Deg);
    }
}
