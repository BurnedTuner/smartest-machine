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
        if (Input.GetMouseButtonDown(0))
            _gun.Shoot(_camera.ScreenToWorldPoint(Input.mousePosition));
    }
}
