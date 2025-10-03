using Unity.VisualScripting;
using UnityEngine;

public interface IState
{

    void Enter();
    void Update();
    void FixedUpdate();
    void Exit();
}

public sealed class StateMachine
{
    public IState Current { get; private set; }

    public void ChangeState(IState next)
    {
        Current?.Exit();
        Current = next;
        Current?.Enter();
    }
}
