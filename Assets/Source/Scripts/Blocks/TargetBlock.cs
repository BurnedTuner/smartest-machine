using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlock : BaseBlock
{
    [SerializeField] private int _requiredPower;

    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        if(bullet.Power >= _requiredPower)
            Debug.Log("Level complete!");

        bullet.Hit();
    }
}
