using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using System.Collections;

public class EnemySpawner : MonoBehaviour, IEnemyDeathNotifier, IEnemySpawnNotifier
{
    public event Action<Enemy> Died;
    public event Action<Enemy> Spawned;

    [SerializeField] private float _spawnCooldwon;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private EnemyFactory _enemyFactory;

    private List<Enemy> _spawnedEnemies = new List<Enemy>();

    private Coroutine _spawn;
    private Score _score;
    private EnemyRewardConfig _config;

    public void Initialize(Score score, EnemyRewardConfig enemyRewardConfig)
    {
        _score = score;
        _config = enemyRewardConfig;
    }
     
    public void StartWork()
    {
        StopWork();

        _spawn = StartCoroutine(Spawn());
    }

    public void StopWork()
    {
        if (_spawn != null)
            StopCoroutine(_spawn);
    }

    public void KillRandomEnemy()
    {
        if (_spawnedEnemies.Count == 0)
            return;

        _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            if (_score.Value <= _config.MaxReward)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;
                Spawned?.Invoke(enemy);
                _spawnedEnemies.Add(enemy);
            }
            yield return new WaitForSeconds(_spawnCooldwon);
        }
    }

    private void OnEnemyDied(Enemy enemy)
    {
        Died?.Invoke(enemy);
        enemy.Died -= OnEnemyDied;
        _spawnedEnemies.Remove(enemy);
    }
}
