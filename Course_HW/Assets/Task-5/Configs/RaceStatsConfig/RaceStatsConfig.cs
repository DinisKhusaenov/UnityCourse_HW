using UnityEngine;

[CreateAssetMenu(fileName = "RaceStats", menuName = "Stats/RaceStats")]
public class RaceStatsConfig : ScriptableObject
{
    [SerializeField] private OrkStatsConfig _orkStatsConfig;
    [SerializeField] private ElfStatsConfig _elfStatsConfig;
    [SerializeField] private HumanStatsConfig _humanStatsConfig;

    public ElfStatsConfig ElfStatsConfig => _elfStatsConfig;
    public HumanStatsConfig HumanStatsConfig => _humanStatsConfig;
    public OrkStatsConfig OrkStatsConfig => _orkStatsConfig;
}
