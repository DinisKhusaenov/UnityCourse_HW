using System;
using UnityEngine;

[Serializable]
public class OrkStatsConfig
{
    [SerializeField] private int _strength;
    [SerializeField] private int _intelligence;
    [SerializeField] private int _agility;

    public int Strength => _strength;
    public int Intelligence => _intelligence;
    public int Agility => _agility;
}
