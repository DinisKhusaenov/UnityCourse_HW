using System;
using UnityEngine.UI;

public class DeathEnergyFormFactory : EnergyFormFactory
{
    public DeathEnergyFormFactory(EnergyConfig energyConfig, Image icon) : base(energyConfig, icon)
    {
    }

    public override EnergyForm Get()
    {
        return new DeathEnergyForm(EnergyConfig, Icon);
    }
}
