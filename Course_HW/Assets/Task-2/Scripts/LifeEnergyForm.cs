using UnityEngine.UI;

public class LifeEnergyForm : EnergyForm
{
    public LifeEnergyForm(EnergyConfig energyConfig, Image icon) : base(energyConfig, icon)
    {
    }

    public override void ChangeEnergyIcon()
    {
        Icon.sprite = EnergyConfig.LifeEnergyConfig.LifeEnergyIcon;
    }
}
