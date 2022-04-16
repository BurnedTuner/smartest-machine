using System;
using UnityEngine;

public class TargetBlock : Block
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _hitColor;
    [SerializeField] private int _requiredPower;

    public event Action<TargetBlock> Activated;

    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        _spriteRenderer.color = _hitColor;
        Activated?.Invoke(this);

        bullet.Hit();
    }
}
