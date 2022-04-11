using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
    [SerializeField, Min(0)] private float _speed;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    public void Move(Vector2 normalizedInput)
    {
        _rigidbody.velocity = normalizedInput * _speed * Time.deltaTime;
    }
}
