public class WalkingState : MoveState
{
    private WalkingStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
        _config = character.Config.WalkingStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;
    }

    public override void Update()
    {
        base.Update();
    }
}
