using Zenject;

public class LevelInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindLevel();
    }

    private void BindLevel()
    {
        Container.BindInterfacesAndSelfTo<Level>().AsSingle();
    }
}
