using System.Collections.Generic;
using UnityEngine;

public class Levels 
{
    private readonly string CurrentLevelKey = nameof(CurrentLevelKey);
    private readonly List<string> _levels;

    public Levels()
    {
        _levels = new List<string>()
        {
            "Level1",
            "Level2",
            "Level3",
            "Level4",
            "Level5",
            "Level6",
            "Level7"
        };

        CurrentLevel = PlayerPrefs.GetString(CurrentLevelKey, _levels[0]);
    }

    public string CurrentLevel { get; private set; }

    public string NextLevel()
    {
        int currentLevelIndex = _levels.IndexOf(CurrentLevel);
        int nextLevelIndex = currentLevelIndex == _levels.Count - 1 ? 0 : currentLevelIndex + 1;
        CurrentLevel = _levels[nextLevelIndex];

        PlayerPrefs.SetString(CurrentLevelKey, CurrentLevel);

        return CurrentLevel;
    }
}
