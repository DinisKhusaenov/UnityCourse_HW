using UnityEngine;

public class DecoratorBootstrap : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private RaceStatsConfig _raceStatsConfig;
    [SerializeField] private SpecializationStatsConfig _specializationStatsConfig;
    [SerializeField] private PassiveAbilityStatsConfig _passiveAbilityStatsConfig;
    [SerializeField] private RaceTypes _raceType;
    [SerializeField] private SpecializationTypes _specializationType;
    [SerializeField] private PassiveAbilitiesTypes _passiveAbilitiesType;

    private IStatProvider _statProvider;

    private void Awake()
    {
        _statProvider = new RaceStats(_raceType, _raceStatsConfig);
        _statProvider = new SpecializationStats(_statProvider, _specializationStatsConfig, _specializationType);
        _statProvider = new PassiveAbilityStats(_statProvider, _passiveAbilityStatsConfig, _passiveAbilitiesType);

        _character.Initialize(_statProvider.GetStats());
    }

    private void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            _character.ShowStats();
    }
}
