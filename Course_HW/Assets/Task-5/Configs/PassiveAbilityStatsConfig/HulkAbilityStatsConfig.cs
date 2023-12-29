using System;
using UnityEngine;

[Serializable]
public class HulkAbilityStatsConfig
{
    [SerializeField] private int _strength;

    public int Strength => _strength;
}
