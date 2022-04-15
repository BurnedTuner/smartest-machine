using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : Block
{
    [SerializeField] private MoveableObject _moveableObject;

    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        normal = -normal.normalized;

        if(Mathf.Abs(normal.x) == 1 || Mathf.Abs(normal.y) == 1)
        {
            _moveableObject.TryMove(normal);
        }

        bullet.Hit();
    }
}
