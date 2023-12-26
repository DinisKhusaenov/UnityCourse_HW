using UnityEngine;
using UnityEngine.UI;

public abstract class EnergyForm
{
    protected EnergyConfig EnergyConfig;
    protected Image Icon;

    public EnergyForm(EnergyConfig energyConfig, Image icon)
    {
        EnergyConfig = energyConfig;
        Icon = icon;
    }

    public abstract void ChangeEnergyIcon();
}
