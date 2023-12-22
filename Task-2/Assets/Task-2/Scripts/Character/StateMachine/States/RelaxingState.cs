using UnityEngine;
using UnityEngine.InputSystem;

public class RelaxingState : MovementState
{
    private const int ZeroSpeed = 0;

    public RelaxingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data, Vector3 relaxPosition, Vector3 workPosition) : base(stateSwitcher, character, data, relaxPosition, workPosition)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Data.TargetPosition = WorkPosition;
        Data.Speed = ZeroSpeed;
    }

    public override void Exit()
    {
        base.Exit();

    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.Move.started += StartMoving;
    }

    protected override void RemoveInputActionsCallbacks()
    {
        base.RemoveInputActionsCallbacks();

        Input.Movement.Move.started -= StartMoving;
    }

    private void StartMoving(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<RunningState>();
}
