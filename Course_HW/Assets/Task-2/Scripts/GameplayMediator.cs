using System;

public class GameplayMediator : IDisposable
{
    private DefeatPanel _defeatPanel;
    private Level _level;

    public GameplayMediator(Level level, DefeatPanel defeatPanel)
    {
        _level = level;
        _defeatPanel = defeatPanel;
        _level.Defeat += OnLevelDefeat;
    }

    private void OnLevelDefeat() => _defeatPanel.Show();

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();   
    }

    public void Dispose()
    {
        _level.Defeat -= OnLevelDefeat;
    }
}
