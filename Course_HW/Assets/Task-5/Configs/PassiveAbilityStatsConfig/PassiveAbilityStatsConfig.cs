using UnityEngine;

[CreateAssetMenu(fileName = "PassiveAbilityStats", menuName = "Stats/PassiveAbilityStats")]
public class PassiveAbilityStatsConfig : ScriptableObject
{
    [SerializeField] private MegaBrainAbilityStatsConfig _megaBrainAbilityStatsConfig;
    [SerializeField] private HulkAbilityStatsConfig _hulkAbilityStatsConfig;
    [SerializeField] private InvisibleAbilityStatsConfig _invisibleAbilityStatsConfig;

    public MegaBrainAbilityStatsConfig MegaBrainAbilityStatsConfig => _megaBrainAbilityStatsConfig;
    public HulkAbilityStatsConfig HulkAbilityStatsConfig => _hulkAbilityStatsConfig;
    public InvisibleAbilityStatsConfig InvisibleAbilityStatsConfig => _invisibleAbilityStatsConfig;
}
