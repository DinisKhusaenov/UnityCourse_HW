using UnityEngine;

[CreateAssetMenu(fileName = "EnemyReward", menuName = "EnemyReward/EnemyReward")]
public class EnemyRewardConfig : ScriptableObject
{
    [SerializeField] private int _orkReward;
    [SerializeField] private int _elfReward;
    [SerializeField] private int _humanReward;
    [SerializeField] private int _maxReward;

    public int OrkReward => _orkReward;
    public int ElfReward => _elfReward;
    public int HumanReward => _humanReward;
    public int MaxReward => _maxReward;
}
