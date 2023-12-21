using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    private PlayerInput _input;
    private CharacterStateMachine _stateMachine;
    private CharacterController _characterController;
    private CharacterConfig _characterConfig;

    public PlayerInput Input => _input;
    public CharacterController Controller => _characterController;
    public CharacterConfig Config => _characterConfig;

    public void Initialization(Vector3 workPosition, Vector3 relaxPosition, CharacterConfig config)
    {
        _characterController = GetComponent<CharacterController>();
        _characterConfig = config;

        _stateMachine = new CharacterStateMachine(this, relaxPosition, workPosition);
    }

    private void Awake()
    {
        _input = new PlayerInput();
    }

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();

    private void Update()
    {
        _stateMachine.Update();
    }
}
