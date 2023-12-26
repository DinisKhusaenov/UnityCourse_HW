using System;
using UnityEngine;

[Serializable]
public class DeathEnergyConfig
{
    [SerializeField] private Sprite _deathEnergyIcon;

    public Sprite DeathEnergyIcon => _deathEnergyIcon;
}
