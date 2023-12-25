using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private PlayerView _playerView;
    [SerializeField] private PlayerConfig _playerConfig;

    private PlayerInput _input;
    private GameplayMediator _mediator;
    private PlayerLevel _playerLevel;
    private Health _health;
    private Player _player;

    private void Awake()
    {
        _playerLevel = new PlayerLevel();
        _input = new PlayerInput();
        _health = new Health(_playerConfig.HealthConfig);

        _mediator = new GameplayMediator(_defeatPanel, _playerLevel, _playerView, _health);
        _player = new Player(_input, _playerConfig, _health, _playerLevel);
    }
}
