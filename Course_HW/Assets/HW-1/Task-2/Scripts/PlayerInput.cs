using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput: MonoBehaviour
{
    private Button _shootButton;

    public event Action ShootButtonClicked;

    public void Initialize(Button shootButton)
    {
        _shootButton = shootButton;
    }

    private void Start()
    {
        _shootButton?.onClick.AddListener(ShootButtonClick);
    }

    private void ShootButtonClick()
    {
        ShootButtonClicked?.Invoke();
    }
}
