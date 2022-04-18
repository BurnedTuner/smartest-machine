using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlockSound : MonoBehaviour
{
    [SerializeField] private TargetBlock _targetBlock;
    [SerializeField] private AudioSource _sound;

    private void OnEnable()
    {
        _targetBlock.Activated += OnActivated;
    }

    private void OnDisable()
    {
        _targetBlock.Activated -= OnActivated;
    }

    private void OnActivated(TargetBlock targetBlock)
    {
        _sound.Play();
        this.enabled = false;
    }
}
