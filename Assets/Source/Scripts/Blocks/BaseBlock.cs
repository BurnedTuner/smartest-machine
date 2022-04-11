using UnityEngine;

public abstract class BaseBlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            OnBulletCollision(bullet, collision.contacts[0].normal);
            Debug.Log(collision.otherCollider.name);
        }
    }

    protected abstract void OnBulletCollision(Bullet bullet, Vector3 normal);
}
