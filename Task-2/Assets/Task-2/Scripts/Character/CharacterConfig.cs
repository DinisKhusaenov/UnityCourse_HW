using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private WorkingStateConfig _workingStateConfig;

    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public WorkingStateConfig WorkingStateConfig => _workingStateConfig;
}
