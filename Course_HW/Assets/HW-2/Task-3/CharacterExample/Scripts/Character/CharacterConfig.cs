using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharaterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private AirbornStateConfig _airbornStateConfig;
    [SerializeField] private WalkingStateConfig _walkingStateConfig;
    [SerializeField] private FastRunnigStateConfig _fastRunnigStateConfig;

    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
    public FastRunnigStateConfig FastRunnigStateConfig => _fastRunnigStateConfig;
}
