using System;

public class SpecializationStats : IStatProvider
{
    private IStatProvider _statProvider;
    private SpecializationStatsConfig _config;
    private SpecializationTypes _specializationType;

    public SpecializationStats(IStatProvider statProvider, SpecializationStatsConfig config, SpecializationTypes specializationType)
    {
        _statProvider = statProvider;
        _config = config;
        _specializationType = specializationType;
    }

    public CharacterStats GetStats()
    {
        return new CharacterStats(_statProvider.GetStats(), GetSpecializationStats());
    }

    private CharacterStats GetSpecializationStats()
    {
        switch (_specializationType)
        {
            case SpecializationTypes.Thief:
                return new CharacterStats(_config.ThiefStatsConfig.Strength, _config.ThiefStatsConfig.Intelligence, _config.ThiefStatsConfig.Agility);

            case SpecializationTypes.Mage:
                return new CharacterStats(_config.MageStatsConfig.Strength, _config.MageStatsConfig.Intelligence, _config.MageStatsConfig.Agility);

            case SpecializationTypes.Barbarian:
                return new CharacterStats(_config.BarbarianStatsConfig.Strength, _config.BarbarianStatsConfig.Intelligence, _config.BarbarianStatsConfig.Agility);

            default:
                throw new NotImplementedException($"{_specializationType} not found!");
        }
    }
}
