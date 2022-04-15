using UnityEngine;

public class InputRoot : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;
    [SerializeField] private CharacterGun _gun;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 normilizedDirection = new Vector2(x, y).normalized;
        _movement.Move(normilizedDirection);

        if (Input.GetMouseButtonDown(0))
            _gun.Shoot(_camera.ScreenToWorldPoint(Input.mousePosition));
    }
}
