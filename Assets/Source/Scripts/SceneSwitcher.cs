using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private Levels _levels;

    private void Awake()
    {
        _levels = new Levels();
    }

    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene(_levels.CurrentLevel);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(_levels.NextLevel());
    }
}
