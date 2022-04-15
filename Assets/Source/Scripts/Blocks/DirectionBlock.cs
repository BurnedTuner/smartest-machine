using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionBlock : BaseBlock
{
    [SerializeField] private Transform _directionPoint;

    private float _newAngle;

    private void Awake()
    {
        Vector3 direction = _directionPoint.position - transform.position;
        _newAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }

    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        Redirect(bullet);
    }


    private void Redirect(Bullet bullet)
    {
        bullet.transform.position = _directionPoint.position;
        bullet.SetAngle(_newAngle);
        bullet.Power++;
    }
}