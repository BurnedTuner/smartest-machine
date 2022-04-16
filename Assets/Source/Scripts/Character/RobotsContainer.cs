using System.Collections.Generic;
using UnityEngine;

public class RobotsContainer : MonoBehaviour
{
    [SerializeField] private List<Robot> _robots;

    private Robot _currentRobot;

    private void Awake()
    {
        _currentRobot = _robots[0];

        foreach (var robot in _robots)
            robot.Disable();

        _currentRobot.Enable();
    }

    private void OnEnable()
    {
        foreach (var robot in _robots)
            robot.Hit += OnRobotHit;
    }

    private void OnDisable()
    {
        foreach (var robot in _robots)
            robot.Hit -= OnRobotHit;
    }

    private void OnRobotHit(Robot robot)
    {
        if (robot == _currentRobot)
            return;

        _currentRobot.Disable();
        _currentRobot = robot;
        _currentRobot.Enable();
    }

#if UNITY_EDITOR
    [ContextMenu(nameof(SetupRobots))]
    private void SetupRobots()
    {
        var targetBlocks = FindObjectsOfType<Robot>(true);

        _robots.Clear();
        _robots.AddRange(targetBlocks);
    }
#endif
}
