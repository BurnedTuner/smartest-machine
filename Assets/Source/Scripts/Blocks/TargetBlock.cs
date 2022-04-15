using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlock : BaseBlock
{
    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        Debug.Log("Level complete!");
        Destroy(bullet.gameObject);
    }
}
