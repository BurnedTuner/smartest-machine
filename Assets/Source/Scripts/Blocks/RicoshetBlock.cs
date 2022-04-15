using UnityEngine;

public class RicoshetBlock : Block
{
    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        Vector2 newDirection = Vector2.Reflect(bullet.transform.right, normal);
        bullet.SetAngle(Mathf.Atan2(newDirection.y, newDirection.x) * Mathf.Rad2Deg);

        bullet.AddPower();
    }
}
