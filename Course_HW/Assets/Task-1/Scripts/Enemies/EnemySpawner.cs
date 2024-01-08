using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : IPause
{
    private float _spawnCooldown;
    private List<Transform> _spawnPoints;
    private EnemyFactory _enemyFactory;

    private Coroutine _spawn;
    private MonoBehaviour _context;

    private bool _isPaused;

    public EnemySpawner(EnemyFactory enemyFactory, PauseHandler pauseHandler, EnemySpawnerData data)
    {
        _enemyFactory = enemyFactory;
        _spawnCooldown = data.SpawnCooldown;
        _spawnPoints = new List(data.SpawnPoints);
        _context = data.Context;
        pauseHandler.Add(this);
    }

    public void StartWork()
    {
        StopWork();

        _spawn = _context.StartCoroutine(Spawn());
    }

    public void SetPause(bool isPaused) => _isPaused = isPaused;

    public void StopWork()
    {
        if (_spawn != null)
            _context.StopCoroutine(_spawn);
    }

    private IEnumerator Spawn()
    {
        float time = 0;

        while (true)
        {
            while(time < _spawnCooldown)
            {
                if(_isPaused == false)
                    time += Time.deltaTime;

                yield return null;
            }

            Enemy enemy = _enemyFactory.Get((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
            enemy.MoveTo(_spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)].position);
            time = 0;
        }
    }
}
