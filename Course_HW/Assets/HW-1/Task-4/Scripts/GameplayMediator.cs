using System;

public class GameplayMediator: IDisposable
{
    private VictoryPanel _victoryPanel;
    private Level _level;

    public GameplayMediator(VictoryPanel victoryPanel, Level level)
    {
        _victoryPanel = victoryPanel;
        _level = level;
        _victoryPanel.Hide();

        _victoryPanel.MenuClick += OnMainMenuClick;
        _victoryPanel.RestartClick += OnRestartClick;

        _level.LevelWin += OnLevelWin;
    }

    public void Dispose()
    {
        _victoryPanel.MenuClick -= OnMainMenuClick;
        _victoryPanel.RestartClick -= OnRestartClick;

        _level.LevelWin -= OnLevelWin;
    }

    private void OnLevelWin() => _victoryPanel.Show();

    private void OnRestartClick() => _level.OnRestartClick();

    private void OnMainMenuClick() => _level.OnMainMenuClick();
}
