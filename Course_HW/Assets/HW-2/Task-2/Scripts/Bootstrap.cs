using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private Transform _relaxPoisition;
    [SerializeField] private Transform _workPoisition;
    [SerializeField] private CharacterConfig _characterConfig;

    private void Awake()
    {
        _character.Initialization(_workPoisition.position, _relaxPoisition.position, _characterConfig);
    }
}
