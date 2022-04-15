using UnityEngine;

public class Boot : MonoBehaviour
{
    [SerializeField] private SceneSwitcher _sceneSwitcher;

    private void Awake()
    {
        _sceneSwitcher.LoadCurrentLevel();
    }
}
