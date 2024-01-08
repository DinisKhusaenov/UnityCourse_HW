using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Bootstrap : MonoBehaviour
{
    private EnemySpawner _enemySpawner;
    private PauseHandler _pauseHandler;

    [Inject]
    private void Construct(PauseHandler pauseHandler, EnemySpawner enemySpawner)
    {
        _pauseHandler = pauseHandler;
        _enemySpawner = enemySpawner;
    }

    private void Awake()
    {
        _enemySpawner.StartWork();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _pauseHandler.SetPause(true);

        if(Input.GetKeyDown(KeyCode.W))
            _pauseHandler.SetPause(false);
    }
}
