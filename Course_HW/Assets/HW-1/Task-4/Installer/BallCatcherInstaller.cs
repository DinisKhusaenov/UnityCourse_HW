using UnityEngine;
using Zenject;

public class BallCatcherInstaller : MonoInstaller
{
    [SerializeField] private BallCatcher _prefab;
    [SerializeField] private Transform _spawnPosition;
    public override void InstallBindings()
    {
        BindInstance();
    }

    private void BindInstance()
    {
        BallCatcher ballCatcher = Container.InstantiatePrefabForComponent<BallCatcher>(_prefab, _spawnPosition.position, Quaternion.identity, null);
        Container.Bind<BallCatcher>().FromInstance(ballCatcher).AsSingle();
    }
}
