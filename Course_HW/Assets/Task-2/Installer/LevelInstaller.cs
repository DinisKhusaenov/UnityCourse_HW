using Zenject;

public class LevelInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindLevel();
    }

    private void BindLevel()
    {
        Container.Bind<Level>().AsSingle();
    }
}
