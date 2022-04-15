using UnityEngine;
using TMPro;

public class BreakableBlock : Block
{
    [SerializeField] private TMP_Text _text;
    [SerializeField, Min(1)] private int _targetHits;

    private int _currentHits;

    private void OnValidate()
    {
        UpdateText();
    }

    protected override void OnBulletCollision(Bullet bullet, Vector3 normal)
    {
        bullet.Hit();

        _currentHits += 1;
        UpdateText();

        if (_targetHits - _currentHits <= 0)
            gameObject.SetActive(false);
    }

    private void UpdateText()
    {
        _text.text = (_targetHits - _currentHits).ToString();
    }
}
