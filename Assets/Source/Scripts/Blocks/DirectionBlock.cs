using UnityEngine;

public class DirectionBlock : Block
{
    [SerializeField] private Transform _directionPoint;
    [SerializeField] private SpriteRenderer _arrow;

    private float _newAngle;

    private void Awake()
    {
        Vector3 direction = _directionPoint.position - transform.position;
        _newAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _arrow.transform.rotation = Quaternion.Euler(0, 0, _newAngle);
    }

    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        bullet.transform.position = _directionPoint.position;
        bullet.SetAngle(_newAngle);
    }
}