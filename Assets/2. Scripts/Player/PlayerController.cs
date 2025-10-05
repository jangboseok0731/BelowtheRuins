using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }
    private InputSystem_Actions actions;
    public PlayerStateSO model;
    public PlayerAnimate view;

    // 이니셜라이즈
    public void Initialize(PlayerStateSO model, InputSystem_Actions action,PlayerAnimate view)
    {
        this.model = model;
        this.actions = actions;
        this.view = view;
        
        stateMachine = new StateMachine();
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
        Vector2 move = actions.Player.Move.ReadValue<Vector2>();
        bool run = actions.Player.Run.IsPressed();
        
        if(move ==  Vector2.zero)
            stateMachine.ChangeState(new PlayerIdleState(this));
        else if(run)
            stateMachine.ChangeState(new PlayerRunState(this));
        else
            stateMachine.ChangeState(new PlayerWalkState(this));
        
            
    }
}
