using UnityEngine;

public class InputRoot : MonoBehaviour
{
    [SerializeField] private CharacterGun _gun;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector2 worldMousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
            _gun.Shoot(worldMousePosition);

        _gun.Rotate(worldMousePosition);
    }
}
