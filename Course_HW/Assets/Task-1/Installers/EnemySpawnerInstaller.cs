using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemySpawnerInstaller : MonoInstaller
{
    [SerializeField] private float _spawnCooldown;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private MonoBehaviour _context;

    public override void InstallBindings()
    {
        BindEnemyFactory();
        BindEnemySpawnerData();
        BindEnemySpawner();
    }

    private void BindEnemySpawnerData()
    {
        Container.Bind<EnemySpawnerData>().AsSingle().WithArguments(_spawnPoints, _spawnCooldown, _context);
    }

    private void BindEnemySpawner()
    {
        Container.Bind<EnemySpawner>().AsSingle();
    }

    private void BindEnemyFactory()
    {
        Container.Bind<EnemyFactory>().AsSingle();
    }
}
