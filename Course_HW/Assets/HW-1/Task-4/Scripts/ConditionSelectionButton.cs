using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ConditionSelectionButton : MonoBehaviour
{
    public event Action<VictoryConditionsEnum> Click;

    [SerializeField] private VictoryConditionsEnum _condition;
    
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick() => Click?.Invoke(_condition);
}
