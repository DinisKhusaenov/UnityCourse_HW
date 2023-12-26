using UnityEngine.UI;

public abstract class EnergyFormFactory
{
    protected EnergyConfig EnergyConfig;
    protected Image Icon;

    protected EnergyFormFactory(EnergyConfig energyConfig, Image icon)
    {
        EnergyConfig = energyConfig;
        Icon = icon;
    }

    public abstract EnergyForm Get();
}
