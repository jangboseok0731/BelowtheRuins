using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }
    public InputSystem_Actions actions;
    public PlayerStateSO model;
    public PlayerAnimate view;

    
    // 이니셜라이즈
    public void Initialize(PlayerStateSO model, InputSystem_Actions action,PlayerAnimate view)
    {
        this.model = model;
        actions = action;
        this.view = view;
        
        stateMachine = new StateMachine();
        stateMachine.ChangeState(new PlayerIdleState(this));
    }
    public void Start()
    {
        
    }


    private void Update()
    {
        stateMachine.Update();
    }
    

    
}
