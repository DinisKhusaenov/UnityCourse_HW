using UnityEngine;

public class RelaxingState : MovementState
{
    private const int ZeroSpeed = 0;

    private bool _isRelax;

    public RelaxingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data, Vector3 relaxPosition, Vector3 workPosition) : base(stateSwitcher, character, data, relaxPosition, workPosition)
    {
    }

    public override void Enter()
    {
        base.Enter();

        Data.TargetPosition = WorkPosition;
        Data.Speed = ZeroSpeed;
        _isRelax = true;
    }

    public override void Exit()
    {
        base.Exit();

        _isRelax = false;
    }

    public override void HandleInput()
    {
        base.HandleInput();

        Input.Movement.Move.performed += context => StartMoving();
    }

    private void StartMoving()
    {
        if (_isRelax)
            StateSwitcher.SwitchState<RunningState>();
    }
}
