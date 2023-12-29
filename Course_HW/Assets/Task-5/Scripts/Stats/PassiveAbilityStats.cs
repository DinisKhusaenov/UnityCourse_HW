using System;

public class PassiveAbilityStats: IStatProvider
{
    private const int ZeroStat = 0;

    private IStatProvider _statProvider;
    private PassiveAbilityStatsConfig _config;
    private PassiveAbilitiesTypes _passiveAbilityType;

    public PassiveAbilityStats(IStatProvider statProvider, PassiveAbilityStatsConfig config, PassiveAbilitiesTypes types)
    {
        _statProvider = statProvider;
        _config = config;
        _passiveAbilityType = types;
    }

    public CharacterStats GetStats()
    {
        return new CharacterStats(_statProvider.GetStats(), GetPassiveAbilityStats());
    }

    private CharacterStats GetPassiveAbilityStats()
    {
        switch (_passiveAbilityType)
        {
            case PassiveAbilitiesTypes.MegaBrain:
                return new CharacterStats(ZeroStat, _config.MegaBrainAbilityStatsConfig.Intelligence, ZeroStat);

            case PassiveAbilitiesTypes.Hulk:
                return new CharacterStats(_config.HulkAbilityStatsConfig.Strength, ZeroStat , ZeroStat);

            case PassiveAbilitiesTypes.Invisible:
                return new CharacterStats(ZeroStat, ZeroStat, _config.InvisibleAbilityStatsConfig.Agility);

            default:
                throw new NotImplementedException($"{_passiveAbilityType} not found!");
        }
    }
}
