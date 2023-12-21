using UnityEngine;

public class RunningState : MovementState
{
    private RunningStateConfig _config;
    private bool _isGoToWork;

    public RunningState(IStateSwitcher stateSwitcher, Character character, StateMachineData data, Vector3 relaxPosition, Vector3 workPosition) : base(stateSwitcher, character, data, relaxPosition, workPosition)
    {
        _isGoToWork = true;
        _config = character.Config.RunningStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;
        Data.DistanceToTarget = _config.DistanceToTarget;
    }

    public override void Update()
    {
        base.Update();

        if ((GetDistanceToTarget(WorkPosition) <= Data.DistanceToTarget) && _isGoToWork) 
        {
            StateSwitcher.SwitchState<WorkingState>();
            _isGoToWork = false;
        }

        if ((GetDistanceToTarget(RelaxPosition) <= Data.DistanceToTarget) && !_isGoToWork)
        {
            StateSwitcher.SwitchState<RelaxingState>();
            _isGoToWork = true;
        }
    }
}
