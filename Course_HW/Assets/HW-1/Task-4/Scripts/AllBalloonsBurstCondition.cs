using System.Collections.Generic;

public class AllBalloonsBurstCondition : WinningCondition
{
    private int _counter;

    public AllBalloonsBurstCondition(int numberOfAllBalls) : base(numberOfAllBalls)
    {
    }

    public override bool IsWin(Ball ball)
    {
        _counter++;

        if (_counter == _numberOfAllBalls)   
            _isWin = true;

        return _isWin;
    }
}
