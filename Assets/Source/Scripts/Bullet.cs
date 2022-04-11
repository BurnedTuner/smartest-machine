using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _acceleraion;

    private float _currentSpeed;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _currentSpeed = _startSpeed;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _currentSpeed += _acceleraion;

        _currentSpeed = Mathf.Clamp(_currentSpeed, 0, _maxSpeed);

        _rigidbody.velocity = (Vector2)transform.right * _currentSpeed * Time.deltaTime;
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
