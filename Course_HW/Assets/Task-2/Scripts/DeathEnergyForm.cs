using UnityEngine.UI;

public class DeathEnergyForm : EnergyForm
{
    public DeathEnergyForm(EnergyConfig energyConfig, Image icon) : base(energyConfig, icon)
    {
    }

    public override void ChangeEnergyIcon()
    {
        Icon.sprite = EnergyConfig.DeathEnergyConfig.DeathEnergyIcon;
    }
}
