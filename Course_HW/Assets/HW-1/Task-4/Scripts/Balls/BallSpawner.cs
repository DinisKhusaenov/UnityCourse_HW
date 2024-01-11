using System;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner
{
    private List<Transform> _spawnPoints;
    private BallFactory _ballFactory;
    private List<Ball> _balls;

    public BallSpawner(List<Transform> spawnPoints, BallFactory ballFactory)
    {
        _spawnPoints = spawnPoints;
        _ballFactory = ballFactory;

        _balls = new List<Ball>();
    }

    public List<Ball> Spawn()
    {
        for (int i = 0; i < _spawnPoints.Count; i++)
        {
            Ball ball = _ballFactory.Get((ColorsEnum)UnityEngine.Random.Range(0, Enum.GetValues(typeof(ColorsEnum)).Length));
            ball.transform.position = _spawnPoints[i].position;

            _balls.Add(ball);
        }

        return _balls;
    }
}
