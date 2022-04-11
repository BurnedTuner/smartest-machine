using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGun : MonoBehaviour
{
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private float _shootOffsetRadius;

    public void Shoot(Vector2 worldMousePosition)
    {
        Vector3 normalizedDirection = (worldMousePosition - (Vector2)transform.position).normalized;
        Bullet bulletInstance = Instantiate(_bulletTemplate, transform.position + normalizedDirection * _shootOffsetRadius, Quaternion.identity);
        bulletInstance.SetAngle(Mathf.Atan2(worldMousePosition.y - transform.position.y, worldMousePosition.x - transform.position.x) * Mathf.Rad2Deg);
    }
}
