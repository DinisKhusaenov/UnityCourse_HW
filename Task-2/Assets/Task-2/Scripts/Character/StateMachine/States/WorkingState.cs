using UnityEngine;

public class WorkingState : MovementState
{
    private const int ZeroSpeed = 0;
    private const int ZeroTime = 0;

    private WorkingStateConfig _config;
    private float _timer;
    private bool _isWorks;

    public WorkingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data, Vector3 relaxPosition, Vector3 workPosition) : base(stateSwitcher, character, data, relaxPosition, workPosition)
    {
        _config = character.Config.WorkingStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        Data.TargetPosition = RelaxPosition;
        Data.Speed = ZeroSpeed;
        _isWorks = true;
        _timer = ZeroTime;
    }

    public override void Update()
    {
        if (_isWorks && _timer >= _config.WorkingTime) 
        {
            StateSwitcher.SwitchState<RunningState>();
            _isWorks = false;
        }

        _timer += Time.deltaTime;
    }
}
