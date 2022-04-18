using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSound : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private CharacterGun _gun;

    private void OnEnable()
    {
        _gun.Shot += OnShot;
    }

    private void OnDisable()
    {
        _gun.Shot -= OnShot;
    }

    private void OnShot()
    {
        _sound.Play();
    }
}
