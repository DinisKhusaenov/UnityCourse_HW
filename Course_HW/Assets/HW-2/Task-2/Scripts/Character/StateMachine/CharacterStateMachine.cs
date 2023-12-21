using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public CharacterStateMachine(Character character, Vector3 relaxPosition, Vector3 workPosition)
    {
        StateMachineData data = new StateMachineData();
        _states = new List<IState>()
        {
            new RelaxingState(this, character, data, relaxPosition, workPosition),
            new RunningState(this, character, data, relaxPosition, workPosition),
            new WorkingState(this, character, data, relaxPosition, workPosition)
        };

        _currentState = _states[0];
        _currentState.Enter();
        _currentState.HandleInput();
    }

    public void SwitchState<State>() where State : IState
    {
        IState state = _states.FirstOrDefault(state => state is State);

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void HandleInput() => _currentState.HandleInput();

    public void Update() => _currentState.Update();
}
