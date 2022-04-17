using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody.velocity = (Vector2)transform.right * _speed;
    }
    public void SetAngle(float zAngle)
    {
        transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
