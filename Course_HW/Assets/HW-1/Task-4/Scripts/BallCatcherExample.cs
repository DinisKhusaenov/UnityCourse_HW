using System.Collections.Generic;
using UnityEngine;

public class BallCatcherExample : MonoBehaviour
{
    private const int CountBalls = 1;

    [SerializeField] private Ball[] _balls;
    [SerializeField] BallCatcher _ballCatcher;

    private void Awake()
    {
        _ballCatcher.Initialization(new AllBalloonsBurstCondition(_balls.Length));
    }

    private Dictionary<string, int> GetSortedBalls()
    {
        var sortedBalls = new Dictionary<string, int>();

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
