using System;
using UnityEngine;
using UnityEngine.UI;

public class WinMenu: MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _menu;
    [SerializeField] private Image _background;

    public event Action NextButtonClicked;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    public void Enable()
    {
        _background.enabled = true;
        _menu.SetActive(true);
    }

    private void OnButtonClick()
    {
        NextButtonClicked?.Invoke();
    }
}
