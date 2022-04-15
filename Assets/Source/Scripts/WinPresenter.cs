using System.Collections.Generic;
using UnityEngine;

public class WinPresenter : MonoBehaviour
{
    [SerializeField] private WinMenu _winMenu;
    [SerializeField] private SceneSwitcher _sceneSwitcher;
    [SerializeField] private InputRoot _inputRoot;
    [SerializeField] private List<TargetBlock> _targetBlocks;

    private int _activateTargetBlocks;

    private void OnEnable()
    {
        foreach (var block in _targetBlocks)
            block.Activated += OnTargetBlockActivated;

        _winMenu.NextButtonClicked += OnNextButtonClicked;
    }

    private void OnDisable()
    {
        foreach (var block in _targetBlocks)
            block.Activated -= OnTargetBlockActivated;

        _winMenu.NextButtonClicked -= OnNextButtonClicked;
    }

    private void OnTargetBlockActivated(TargetBlock targetBlock)
    {
        targetBlock.Activated -= OnTargetBlockActivated;

        _activateTargetBlocks += 1;

        if (_activateTargetBlocks >= _targetBlocks.Count)
        {
            _inputRoot.enabled = false;
            _winMenu.Enable();
        }
    }

    private void OnNextButtonClicked()
    {
        _sceneSwitcher.LoadNextLevel();
    }

#if UNITY_EDITOR
    [ContextMenu(nameof(SetupTargetBlocks))]
    private void SetupTargetBlocks()
    {
        var targetBlocks = FindObjectsOfType<TargetBlock>(true);

        _targetBlocks.Clear();
        _targetBlocks.AddRange(targetBlocks);
    }
#endif
}
