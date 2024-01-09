using UnityEngine;
using Zenject;

public class MediatorInstaller : MonoInstaller
{
    [SerializeField] private DefeatPanel _defeatPanel;

    public override void InstallBindings()
    {
        BindMediator();
    }

    private void BindMediator()
    {
        Container.BindInterfacesAndSelfTo<GameplayMediator>().AsSingle().WithArguments(_defeatPanel);
    }
}
