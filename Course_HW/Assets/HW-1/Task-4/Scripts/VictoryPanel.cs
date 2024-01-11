using System;
using UnityEngine;
using UnityEngine.UI;

public class VictoryPanel : MonoBehaviour
{
    public event Action RestartClick;
    public event Action MenuClick;

    [SerializeField] private Button _restart;
    [SerializeField] private Button _menu;

    private void OnEnable()
    {
        _restart.onClick.AddListener(OnRestartClick);
        _menu.onClick.AddListener(OnMenuClick);
    }

    private void OnDisable()
    {
        _restart.onClick.RemoveListener(OnRestartClick);
        _menu.onClick.RemoveListener(OnMenuClick);
    }

    public void Show() => gameObject.SetActive(true);

    public void Hide() => gameObject.SetActive(false);

    private void OnRestartClick() => RestartClick?.Invoke();

    private void OnMenuClick() => MenuClick?.Invoke();
}
