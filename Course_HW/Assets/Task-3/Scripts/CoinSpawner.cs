using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawner
{
    private const String NoPlace = "Нет мест для спавна";

    private List<Vector3> _spawnPoints;
    private CoinFactory _coinFactory;
    private bool _isSpawnPointsEmpty;

    public CoinSpawner(IEnumerable<Vector3> spawnPoints, CoinFactory coinFactory)
    {
        _spawnPoints = spawnPoints.ToList();
        _coinFactory = coinFactory;

        _isSpawnPointsEmpty = false;
    }

    public void Spawn()
    {
        if (_isSpawnPointsEmpty == false)
        {
            _coinFactory.Get(GetRandomPosition());
        }
        else
        {
            Debug.Log(NoPlace);
        }
    }

    private Vector3 GetRandomPosition()
    {
        var randomNumber = Random.Range(0, _spawnPoints.Count);
        var position = _spawnPoints[randomNumber];
        _spawnPoints.Remove(position);

        if (_spawnPoints.Count == 0) _isSpawnPointsEmpty = true;

        return position;
    }
}
