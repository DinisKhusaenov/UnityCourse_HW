public abstract class MoveState : GroundedState
{
    public MoveState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
    }

    public override void Enter()
    {
        base.Enter();

        ChangeCurrentState();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }

    private void ChangeCurrentState()
    {
        switch (Data.CurrentMovementState)
        {
            case MovementStates.WalkingState:
                StateSwitcher.SwitchState<WalkingState>();
                break;

            case MovementStates.RunningState:
                StateSwitcher.SwitchState<RunningState>();
                break;

            case MovementStates.FastRunningState:
                StateSwitcher.SwitchState<FastRunnigState>();
                break;

        }
    }
}
