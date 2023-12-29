using System;
using UnityEngine;

[Serializable]
public class MegaBrainAbilityStatsConfig
{ 
    [SerializeField] private int _intelligence;

    public int Intelligence => _intelligence;
}
