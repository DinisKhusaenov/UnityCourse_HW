using System;
using UnityEngine;

public class Score: IDisposable
{
    private IEnemyDeathNotifier _enemyDeathNotifier;
    private IEnemySpawnNotifier _enemySpawnNotifier;
    private EnemyVisitor _enemyVisitor;
    private EnemyRewardConfig _enemyRewardConfig;

    public Score(IEnemyDeathNotifier enemyDeathNotifier, IEnemySpawnNotifier enemySpawnNotifier, EnemyRewardConfig enemyRewardConfig)
    {
        _enemyDeathNotifier = enemyDeathNotifier;
        _enemySpawnNotifier = enemySpawnNotifier;
        _enemyRewardConfig = enemyRewardConfig;

        _enemyDeathNotifier.Died += OnEnemyKilled;
        _enemySpawnNotifier.Spawned += OnEnemySpawned;

        _enemyVisitor = new EnemyVisitor(_enemyRewardConfig);
    }

    public int Value => _enemyVisitor.Score;

    public void Dispose()
    {
        _enemyDeathNotifier.Died -= OnEnemyKilled;
        _enemySpawnNotifier.Spawned -= OnEnemySpawned;
    }

    public void OnEnemyKilled(Enemy enemy)
    {
        _enemyVisitor.Reduce(enemy);
        Debug.Log($"Ñ÷¸ò: {Value}");
    }

    public void OnEnemySpawned(Enemy enemy)
    {
        _enemyVisitor.Visit(enemy);
        Debug.Log($"Ñ÷¸ò: {Value}");
    }

    private class EnemyVisitor : IEnemyVisitor
    {
        private EnemyRewardConfig _config;

        public EnemyVisitor(EnemyRewardConfig config)
        {
            _config = config;
            Score = 0;
        }

        public int Score { get; private set; }

        public void Visit(Ork ork) => Score += _config.OrkReward;

        public void Visit(Human human) => Score += _config.HumanReward;

        public void Visit(Elf elf) => Score += _config.ElfReward;

        public void Visit(Enemy enemy) => Visit((dynamic)enemy);

        public void Reduce(Ork ork) => Score -= _config.OrkReward;

        public void Reduce(Human human) => Score -= _config.HumanReward;

        public void Reduce(Elf elf) => Score -= _config.ElfReward;

        public void Reduce(Enemy enemy) => Reduce((dynamic)enemy);
    }
}
