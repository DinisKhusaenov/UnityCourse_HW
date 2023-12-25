using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    [SerializeField] private HealthConfig _healthConfig;

    public HealthConfig HealthConfig => _healthConfig;
}
