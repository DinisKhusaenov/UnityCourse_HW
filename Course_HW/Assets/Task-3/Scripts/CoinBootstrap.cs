using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class CoinBootstrap : MonoBehaviour
{
    [SerializeField] private Coin _prefab;
    [SerializeField] private List<Transform> _spawnPoints;

    private CoinFactory _factory;
    private CoinSpawner _spawner;
    private Input _input;

    private void Awake()
    {
        _factory = new CoinFactory(_prefab);
        _spawner = new CoinSpawner(_spawnPoints.Select(point => point.position).ToList(), _factory);
        _input = new Input();
    }

    private void OnEnable()
    {
        _input.Enable();
        _input.Spawn.CreateCoin.started += SpawnCoin;
    }

    private void OnDisable()
    {
        _input.Disable();
        _input.Spawn.CreateCoin.started -= SpawnCoin;
    }

    private void SpawnCoin(InputAction.CallbackContext obj)
    {
        _spawner.Spawn();
    }
}
