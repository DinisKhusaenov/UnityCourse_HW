using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private const int CountBalls = 1;

    [SerializeField] private Ball[] _balls;
    [SerializeField] BallCatcher _ballCatcher;

    private VictoryCondition _victoryCondition;

    private void Awake()
    {
        _victoryCondition = new BallsOfTheSameColorCondition(_balls.Length, _ballCatcher, GetSortedBalls());
    }

    private void OnEnable()
    {
        _victoryCondition.Completed += OnGameWinned;
    }

    private void OnDisable()
    {
        _victoryCondition.Completed -= OnGameWinned;
    }

    private void OnGameWinned()
    {
        Debug.Log("Win");
    }

    private Dictionary<ColorsEnum, int> GetSortedBalls()
    {
        var sortedBalls = new Dictionary<ColorsEnum, int>();

        foreach (Ball ball in _balls)
        {
            if (sortedBalls.ContainsKey(ball.GetColor()))
                sortedBalls[ball.GetColor()] = sortedBalls[ball.GetColor()] + CountBalls;
            else
                sortedBalls.Add(ball.GetColor(), CountBalls);
        }

        return sortedBalls;
    }
}
