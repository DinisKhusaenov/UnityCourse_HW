using System.Collections.Generic;

public class BallsOfTheSameColorCondition : WinningCondition
{
    private const int Counter = 1;

    private Dictionary<string, int> _allBalls;

    public BallsOfTheSameColorCondition(Dictionary<string, int> startBalls) : base(startBalls)
    {
        _allBalls = new Dictionary<string, int>();
    }

    public override bool IsWin(Ball ball)
    {
        if (_allBalls.ContainsKey(ball.GetColor()))
            _allBalls[ball.GetColor()] = _allBalls[ball.GetColor()] + Counter;
        else
            _allBalls.Add(ball.GetColor(), Counter);

        if (_allBalls[ball.GetColor()] == _startBalls[ball.GetColor()] && _allBalls.Count == Counter)
            _isWin = true;

        return _isWin;
    }
}
