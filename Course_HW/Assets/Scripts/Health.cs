using System;

public class Health
{
    private int _value;
    private HealthConfig _config;

    public Health(HealthConfig config)
    {
        _config = config;

        Start();
    }

    public event Action Died;
    public event Action<int> HealthChanged;

    public int Value => _value;

    public void Start()
    {
        _value = _config.MaxHealth;
        HealthChanged?.Invoke(_value);
    }

    public void Add(int value)
    {
        if (value < 0)
            throw new ArgumentException(nameof(value));

        _value += value;

        if (_value > _config.MaxHealth)
            _value = _config.MaxHealth;

        HealthChanged?.Invoke(_value);
    }

    public void Reduce(int value)
    {
        if (value < 0)
            throw new ArgumentException(nameof(value));

        _value -= value;

        if (_value <= 0)
        {
            _value = 0;
            Died?.Invoke();
        }

        HealthChanged?.Invoke(_value);
    }
}
