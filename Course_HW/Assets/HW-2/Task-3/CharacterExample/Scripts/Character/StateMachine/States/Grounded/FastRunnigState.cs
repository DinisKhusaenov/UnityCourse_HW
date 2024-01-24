public class FastRunnigState : MoveState
{
    private FastRunnigStateConfig _config;

    public FastRunnigState(IStateSwitcher stateSwitcher, Character character, StateMachineData data) : base(stateSwitcher, character, data)
    {
        _config = character.Config.FastRunnigStateConfig;
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
