using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGun : MonoBehaviour
{
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private Transform _gunContainer;
    [SerializeField] private float _shootOffsetRadius;

    public void Shoot(Vector2 worldMousePosition)
    {
        Vector3 normalizedDirection = (worldMousePosition - (Vector2)transform.position).normalized;
        Bullet bulletInstance = Instantiate(_bulletTemplate, transform.position + normalizedDirection * _shootOffsetRadius, Quaternion.identity);
        bulletInstance.SetAngle(CalculateAngle(worldMousePosition));
    }

    public void Rotate(Vector2 worldMousePosition)
    {
        _gunContainer.localRotation = Quaternion.Euler(0, 0, CalculateAngle(worldMousePosition));
    }

    private float CalculateAngle(Vector2 worldMousePosition)
    {
        return Mathf.Atan2(worldMousePosition.y - transform.position.y, worldMousePosition.x - transform.position.x) * Mathf.Rad2Deg;
    }
}
