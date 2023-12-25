using System;

public class GameplayMediator: IDisposable
{
    private DefeatPanel _defeatPanel; 
    private PlayerLevel _level;
    private PlayerView _playerView;
    private Health _health;

    public GameplayMediator(DefeatPanel defeatPanel, PlayerLevel playerLevel, PlayerView playerView, Health health)
    {
        _level = playerLevel;
        _defeatPanel = defeatPanel;
        _playerView = playerView;
        _health = health;

        _level.LevelChanged += OnLevelChanged;
        _health.HealthChanged += OnHealthChanged;
        _health.Died += OnDied;
        _defeatPanel.Restarted += RestartGame;

        RestartGame();
    }

    public void Dispose()
    {
        _level.LevelChanged -= OnLevelChanged;
        _health.HealthChanged -= OnHealthChanged;
        _health.Died -= OnDied;
        _defeatPanel.Restarted -= RestartGame;
    }

    private void OnLevelChanged(int value) => _playerView.UpdateLevelText(value); 

    private void OnHealthChanged(int value) => _playerView.UpdateHealthText(value);

    private void OnDied()
    {
        _defeatPanel.Show();
        _playerView.Hide();
    }

    private void RestartGame()
    {
        _defeatPanel.Hide();
        _level.Start();
        _health.Start();
        _playerView.Show();
    }
}
