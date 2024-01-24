using UnityEngine.InputSystem;

public class IdlingState : GroundedState
{
    public IdlingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
    }

    public override void Enter()
    {
        base.Enter();

        View.StartIdling();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.Walk.started += SetWalkingState;
        Input.Movement.FastRun.started += SetFastRunningState;
        Input.Movement.Run.started += SetRunningState;
    }

    protected override void RemoveInputActionsCallbacks()
    {
        base.RemoveInputActionsCallbacks();

        Input.Movement.Walk.started -= SetWalkingState;
        Input.Movement.FastRun.started -= SetFastRunningState;
        Input.Movement.Run.started -= SetRunningState;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopIdling();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            return;

        StateSwitcher.SwitchState<WalkingState>();
    }

    private void SetWalkingState(InputAction.CallbackContext obj) => Data.CurrentMovementState = MovementStates.WalkingState;

    private void SetFastRunningState(InputAction.CallbackContext obj) => Data.CurrentMovementState = MovementStates.FastRunningState;

    private void SetRunningState(InputAction.CallbackContext obj) => Data.CurrentMovementState = MovementStates.RunningState;
}
