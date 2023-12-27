using UnityEngine;

public class VisitorBootstrap : MonoBehaviour
{
    [SerializeField] private EnemySpawner _spawner;
    [SerializeField] private EnemyRewardConfig _rewardConfig;

    private Score _score;

    private void Awake()
    {
        _score = new Score(_spawner, _spawner, _rewardConfig);
        _spawner.Initialize(_score, _rewardConfig);
        _spawner.StartWork();
    }

    private void Update()
    {
        if (UnityEngine.Input.GetKeyUp(KeyCode.Space))
            _spawner.KillRandomEnemy();
    }
}
