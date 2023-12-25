using System;
using UnityEngine.InputSystem;

public class Player : IDisposable
{
    private const int HealthValue = 1;

    private PlayerConfig _config;
    private PlayerInput _input;
    private PlayerLevel _level;
    private Health _health;

    public PlayerConfig Config => _config;
    public PlayerInput Input => _input;
    public PlayerLevel Level => _level;
    public Health Health => _health;

    public Player(PlayerInput input, PlayerConfig config, Health health, PlayerLevel level)
    {
        _config = config;
        _input = input;
        _level = level;
        _health = health;

        _input.Enable();
        _input.Health.Add.started += OnHealthAdded;
        _input.Health.Reduce.started += OnHealthReduced;
        _input.Level.Increase.started += OnLevelIncreased;
    }

    public void Dispose()
    {
        _input.Disable();
        _input.Health.Add.started -= OnHealthAdded;
        _input.Health.Reduce.started -= OnHealthReduced;
        _input.Level.Increase.started -= OnLevelIncreased;
    }

    private void OnHealthAdded(InputAction.CallbackContext obj) => _health.Add(HealthValue);

    private void OnHealthReduced(InputAction.CallbackContext obj) => _health.Reduce(HealthValue);

    private void OnLevelIncreased(InputAction.CallbackContext obj) => _level.OnIncrease();
}
