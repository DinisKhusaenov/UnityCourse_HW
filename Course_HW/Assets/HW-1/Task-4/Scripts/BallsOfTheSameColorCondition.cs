using System;
using System.Collections.Generic;

public class BallsOfTheSameColorCondition : VictoryCondition
{
    private const int Counter = 1;

    private Dictionary<ColorsEnum, int> _allBalls;
    private Dictionary<ColorsEnum, int> _startBalls;

    public override event Action Completed;

    public BallsOfTheSameColorCondition(int numberOfAllBalls, BallCatcher ballCatcher, Dictionary<ColorsEnum, int> balls) : base(numberOfAllBalls, ballCatcher, balls)
    {
        _startBalls = balls;

        _allBalls = new Dictionary<ColorsEnum, int>();
        Catcher.BallCatched += OnBallCatched;
    }

    public override void OnBallCatched(Ball ball)
    {
        if (_allBalls.ContainsKey(ball.GetColor()))
            _allBalls[ball.GetColor()] = _allBalls[ball.GetColor()] + Counter;
        else
            _allBalls.Add(ball.GetColor(), Counter);

        if (_allBalls[ball.GetColor()] == _startBalls[ball.GetColor()] && _allBalls.Count == Counter)
            Completed?.Invoke();
    }

    public override void Dispose()
    {
        Catcher.BallCatched -= OnBallCatched;
    }
}
