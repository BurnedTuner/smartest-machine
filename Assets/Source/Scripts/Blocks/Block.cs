using UnityEngine;

public abstract class Block : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            Vector3 normal = new Vector3();

            foreach(RaycastHit2D hit in Physics2D.CircleCastAll(collision.transform.position, 0.5f, collision.transform.right))
                if(hit.collider == GetComponent<Collider2D>())
                    normal = hit.normal;

            OnBulletCollision(bullet, normal);
        }
    }

    protected abstract void OnBulletCollision(Bullet bullet, Vector3 normal);
}
