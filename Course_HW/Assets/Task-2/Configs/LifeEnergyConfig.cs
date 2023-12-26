using System;
using UnityEngine;

[Serializable]
public class LifeEnergyConfig
{
    [SerializeField] private Sprite _lifeEnergyIcon;

    public Sprite LifeEnergyIcon => _lifeEnergyIcon;
}
