using UnityEngine;

[CreateAssetMenu(fileName = "SpecializationStats", menuName = "Stats/SpecializationStats")]
public class SpecializationStatsConfig : ScriptableObject
{
    [SerializeField] private ThiefStatsConfig _thiefStatsConfig;
    [SerializeField] private MageStatsConfig _mageStatsConfig;
    [SerializeField] private BarbarianStatsConfig _barbarianStatsConfig;

    public ThiefStatsConfig ThiefStatsConfig => _thiefStatsConfig;
    public MageStatsConfig MageStatsConfig => _mageStatsConfig;
    public BarbarianStatsConfig BarbarianStatsConfig => _barbarianStatsConfig;
}
