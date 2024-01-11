using UnityEngine;
using Zenject;

public class GameplayMediatorInstaller : MonoInstaller
{
    [SerializeField] private VictoryPanel _victoryPanel;

    public override void InstallBindings()
    {
        BindMediator();
    }

    private void BindMediator()
    {
        Container.BindInterfacesAndSelfTo<GameplayMediator>().AsSingle().WithArguments(_victoryPanel);
    }
}
