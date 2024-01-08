using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private Player _prefab;
    [SerializeField] private Transform _spawnPoint;

    [SerializeField] private PlayerStatsConfig _playerStatsConfig;

    public override void InstallBindings()
    {
        BindConfig();
        BindInstance();
    }

    private void BindInstance()
    {
        Player player = Container.InstantiatePrefabForComponent<Player>(_prefab, _spawnPoint.position, Quaternion.identity, null);
        Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
    }

    private void BindConfig()
        => Container.Bind<PlayerStatsConfig>().FromInstance(_playerStatsConfig).AsSingle();
}
