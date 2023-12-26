using UnityEngine;

[CreateAssetMenu(fileName = "EnergyConfig", menuName = "Configs/EnergyConfig")]
public class EnergyConfig : ScriptableObject
{
    [SerializeField] private LifeEnergyConfig _lifeEnergyConfig;
    [SerializeField] private DeathEnergyConfig _deathEnergyConfig;

    public LifeEnergyConfig LifeEnergyConfig => _lifeEnergyConfig;
    public DeathEnergyConfig DeathEnergyConfig => _deathEnergyConfig;
}
