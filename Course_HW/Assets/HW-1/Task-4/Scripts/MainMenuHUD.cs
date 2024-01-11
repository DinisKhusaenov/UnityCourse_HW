using UnityEngine;
using Zenject;

public class MainMenuHUD : MonoBehaviour
{
    [SerializeField] private ConditionSelectionButton[] _conditionSelectionButtons;

    private ISceneLoadMediator _mediator;

    [Inject]
    private void Construct(ISceneLoadMediator sceneLoadMediator)
    {
        _mediator = sceneLoadMediator;
    }

    private void OnEnable()
    {
        foreach (var condition in _conditionSelectionButtons)
            condition.Click += OnConditionSelected;
    }

    private void OnConditionSelected(VictoryConditionsEnum victoryConditionEnum)
    {
        _mediator.GoToGameplay(new GameLoadingData(victoryConditionEnum));
    }
}
