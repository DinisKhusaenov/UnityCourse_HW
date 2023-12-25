using System;

public class PlayerLevel
{
    private const int StartLevel = 1;

    private int _level;

    public PlayerLevel()
    {
        _level = StartLevel;

        Start();
    }

    public event Action<int> LevelChanged;

    public void Start()
    {
        _level = StartLevel;
        LevelChanged?.Invoke(_level);
    }

    public void OnIncrease()
    {
        _level++;
        LevelChanged?.Invoke(_level);
    }
}
