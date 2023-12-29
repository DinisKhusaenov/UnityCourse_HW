using System;
using UnityEngine;

[Serializable]
public class InvisibleAbilityStatsConfig
{
    [SerializeField] private int _agility;

    public int Agility => _agility;
}
