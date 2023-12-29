using System;

public class RaceStats : IStatProvider
{
    private RaceTypes _raceType;
    private RaceStatsConfig _config;

    public RaceStats(RaceTypes raceType, RaceStatsConfig config)
    {
        _raceType = raceType;
        _config = config;
    }

    public CharacterStats GetStats()
    {
        switch (_raceType)
        {
            case RaceTypes.Ork:
                return new CharacterStats(_config.OrkStatsConfig.Strength, _config.OrkStatsConfig.Intelligence, _config.OrkStatsConfig.Agility);

            case RaceTypes.Human:
                return new CharacterStats(_config.HumanStatsConfig.Strength, _config.HumanStatsConfig.Intelligence, _config.HumanStatsConfig.Agility);

            case RaceTypes.Elf:
                return new CharacterStats(_config.ElfStatsConfig.Strength, _config.ElfStatsConfig.Intelligence, _config.ElfStatsConfig.Agility);

            default:
                throw new NotImplementedException($"{_raceType} not found!");
        }
    }
}
