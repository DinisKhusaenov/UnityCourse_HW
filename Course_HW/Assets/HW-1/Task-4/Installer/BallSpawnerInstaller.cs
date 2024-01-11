using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BallSpawnerInstaller : MonoInstaller
{
    [SerializeField] private List<Transform> _spawnPoints;


    public override void InstallBindings()
    {
        BindBallFactory();
        BindBallSpawner();
    }

    private void BindBallSpawner()
    {
        Container.Bind<BallSpawner>().AsSingle().WithArguments(_spawnPoints);
    }

    private void BindBallFactory()
    {
        Container.Bind<BallFactory>().AsSingle();
    }
}
