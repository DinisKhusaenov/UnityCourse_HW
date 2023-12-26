using UnityEngine.UI;

public class LifeEnergyFormFactory : EnergyFormFactory
{
    public LifeEnergyFormFactory(EnergyConfig energyConfig, Image icon) : base(energyConfig, icon)
    {
    }

    public override EnergyForm Get()
    {
        return new LifeEnergyForm(EnergyConfig,Icon);
    }
}
