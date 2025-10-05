using System;
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

    public void OnEnable()
    {
        Current?.Enter();
    }

    public void OnDisable()
    {
        Current?.Exit();
    }

    public void Update()
    {
        Current?.Update();
    }
    

    public void FixedUpdate()
    {
        Current?.FixedUpdate();
    }
}
