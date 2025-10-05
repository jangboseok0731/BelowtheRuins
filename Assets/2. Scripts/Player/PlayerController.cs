using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public StateMachine stateMachine;
    public InputSystem_Actions actions;

    void Awake()
    {
        stateMachine = new StateMachine();
        actions = new InputSystem_Actions();
        stateMachine.ChangeState(new PlayerIdleState(this));
    }

    private void OnEnable() => actions.Enable();
    private void OnDisable() => actions.Disable();

    void Update()
    {
        HandleInput();
        stateMachine.Update();
    }
    

    void HandleInput()
    {
        stateMachine.ChangeState(new PlayerWalkState());
    }
}
