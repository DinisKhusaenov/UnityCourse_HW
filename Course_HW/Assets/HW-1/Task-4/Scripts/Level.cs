using System;
using System.Collections.Generic;

public class Level: IDisposable
{
    public event Action LevelWin;

    private const int CountBalls = 1;

    private List<Ball> _balls;
    private Dictionary<ColorsEnum, int> _sortedBalls;
    private BallCatcher _ballCatcher;
    private VictoryCondition _victoryCondition;
    private GameLoadingData _gameLoadingData;
    private BallSpawner _ballSpawner;
    private ISceneLoadMediator _sceneLoadMediator;

    public Level(GameLoadingData gameLoadingData, BallCatcher ballCatcher, BallSpawner ballSpawner, ISceneLoadMediator sceneLoadMediator)
    {
        _gameLoadingData = gameLoadingData;
        _ballCatcher = ballCatcher;
        _ballSpawner = ballSpawner;
        _sceneLoadMediator = sceneLoadMediator;

        _balls = _ballSpawner.Spawn();
        _sortedBalls = GetSortedBalls();
        _victoryCondition = GetVictoryCondition(_gameLoadingData.VictoryConditionEnum);

        _victoryCondition.Completed += OnGameWinned;
    }

    public void Dispose()
    {
        _victoryCondition.Completed -= OnGameWinned;
    }
    public void OnMainMenuClick() => _sceneLoadMediator.GoToMainMenu();

    private void OnGameWinned() => LevelWin?.Invoke();

    public void OnRestartClick() => _sceneLoadMediator.GoToGameplay(_gameLoadingData);

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

    private VictoryCondition GetVictoryCondition(VictoryConditionsEnum victoryConditionEnum)
    {
        switch (victoryConditionEnum)
        {
            case VictoryConditionsEnum.AllBaloonsBurst:
                return new AllBalloonsBurstCondition(_balls.Count, _ballCatcher, _sortedBalls);

            case VictoryConditionsEnum.BallsOfTheSameColor:
                return new BallsOfTheSameColorCondition(_balls.Count, _ballCatcher, _sortedBalls);

            default:
                throw new ArgumentException(nameof(victoryConditionEnum));
        }
    }
}
