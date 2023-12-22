using UnityEngine;

public abstract class MovementState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;
    protected readonly Vector3 RelaxPosition;
    protected readonly Vector3 WorkPosition;

    private readonly Character _character;

    public MovementState(IStateSwitcher stateSwitcher, Character character, StateMachineData data, Vector3 relaxPosition, Vector3 workPosition)
    {
        StateSwitcher = stateSwitcher;
        _character = character;
        Data = data;
        RelaxPosition = relaxPosition;
        WorkPosition = workPosition;

        Data.TargetPosition = workPosition;
    }

    protected PlayerInput Input => _character.Input;
    protected CharacterController CharacterController => _character.Controller;

    private Quaternion TurnRight => new Quaternion(0, 0, 0, 0);
    private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);

    public virtual void Enter()
    {
        Debug.Log(GetType());

        AddInputActionsCallbacks();
    }

    public virtual void Exit()
    {
        RemoveInputActionsCallbacks();
    }

    public virtual void HandleInput()
    {
    }

    public virtual void Update()
    {
        Vector3 velocity = GetConvertedVelocity();

        CharacterController.Move(velocity * Time.deltaTime * Data.Speed);
        _character.transform.rotation = GetRotationFrom(velocity);
    }

    protected virtual void AddInputActionsCallbacks() { }

    protected virtual void RemoveInputActionsCallbacks() { }

    protected float GetDistanceToTarget(Vector3 to) => Vector3.Distance(_character.transform.position, to);

    private Vector3 GetConvertedVelocity() => (Data.TargetPosition - _character.transform.position).normalized;

    private Quaternion GetRotationFrom(Vector3 velocity)
    {
        if (velocity.x > 0)
            return TurnRight;

        if (velocity.x < 0)
            return TurnLeft;

        return _character.transform.rotation;
    }
}
