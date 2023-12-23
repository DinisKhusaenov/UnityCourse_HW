using System;
using System.Collections.Generic;

public class AllBalloonsBurstCondition : VictoryCondition
{
    private int _counter;
    private int _numberOfAllBalls;

    public override event Action Completed;

    public AllBalloonsBurstCondition(int numberOfAllBalls, BallCatcher ballCatcher, Dictionary<ColorsEnum, int> balls) : base(numberOfAllBalls, ballCatcher, balls)
    {
        _numberOfAllBalls = numberOfAllBalls;

        Catcher.BallCatched += OnBallCatched;
    }

    public override void OnBallCatched(Ball ball)
    {
        _counter++;

        if (_counter == _numberOfAllBalls)   
            Completed?.Invoke();
    }

    public override void Dispose()
    {
        Catcher.BallCatched -= OnBallCatched;
    }
}
