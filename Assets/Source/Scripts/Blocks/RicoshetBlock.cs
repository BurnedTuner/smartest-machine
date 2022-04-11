using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RicoshetBlock : BaseBlock
{
    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        Vector3 newDirection = Vector3.Reflect(bullet.transform.right, normal);
        Debug.Log(bullet.transform.right + " " + bullet.transform.eulerAngles.normalized);
        bullet.SetAngle(Mathf.Atan2(newDirection.y - bullet.transform.right.y, newDirection.x - bullet.transform.right.x) * Mathf.Rad2Deg);
    }
}
