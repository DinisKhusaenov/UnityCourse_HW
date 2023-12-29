using System;
using UnityEngine;

public class CharacterStats
{
    private int _strength;
    private int _intelligence;
    private int _agility;

    public CharacterStats(int strength, int intelligence, int agility)
    {
        _strength = strength;
        _intelligence = intelligence;
        _agility = agility;
    }

    public CharacterStats(CharacterStats firstStats, CharacterStats secondStats)
    {
        _strength = firstStats.Strength + secondStats.Strength;
        _intelligence = firstStats.Intelligence + secondStats.Intelligence;
        _agility = firstStats.Agility + secondStats.Agility;
    }

    public int Strength
    {
        get { return _strength; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _strength = value;
        }
    }

    public int Intelligence
    {
        get { return _intelligence; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _intelligence = value;
        }
    }

    public int Agility
    {
        get { return _agility; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _agility = value;
        }
    }
}
