using System;
using System.Collections.Generic;

public abstract class VictoryCondition: IDisposable
{
    protected BallCatcher Catcher;

    public virtual event Action Completed;

    public VictoryCondition(int numberOfAllBalls, BallCatcher ballCatcher, Dictionary<ColorsEnum, int> balls)
    {
        Catcher = ballCatcher;
    }

    public abstract void OnBallCatched(Ball ball);

    public abstract void Dispose();
}
