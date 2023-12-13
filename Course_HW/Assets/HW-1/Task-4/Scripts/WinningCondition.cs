using System.Collections.Generic;

public abstract class WinningCondition
{
    protected int _numberOfAllBalls;
    protected bool _isWin;
    protected Dictionary<string, int> _startBalls;

    public WinningCondition(int numberOfAllBalls)
    {
        _numberOfAllBalls = numberOfAllBalls;

        _isWin = false;
    }

    protected WinningCondition(Dictionary<string, int> startBalls)
    {
        _startBalls = startBalls;

        _isWin = false;
    }

    public abstract bool IsWin(Ball ball);
}
