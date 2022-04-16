using System;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private InputRoot _inputRoot;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _gun;

    public event Action<Robot> Hit; 

    public bool Enabled { get; private set; }

    public void Enable()
    {
        SetActive(true);
        Enabled = true;
    }

    public void Disable()
    {
        SetActive(false);
        Enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            bullet.Hit();
            Hit?.Invoke(this);
        }
    }

    private void SetActive(bool value)
    {
        _inputRoot.enabled = value;
        _gun.SetActive(value);
        _animator.SetBool(RobotAnimationParams.IsEnabled, value);
    }
}

public static class RobotAnimationParams
{
    public const string IsEnabled = nameof(IsEnabled);
}
