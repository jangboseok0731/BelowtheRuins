using UnityEngine;

public class PlayerIdleState : IState
{
    private PlayerController _controller;

    public PlayerIdleState(PlayerController controller)
    {
        this._controller = controller;
    }
    void Start()
    {
        
    }
    public void Enter()
    {
    }
    
    public void FixedUpdate() { }

    public void Exit() { }

    public void Update()
    {
        Vector2 move = _controller.actions.Player.Move.ReadValue<Vector2>();
        if (move != Vector2.zero)
        {
            Debug.Log("PlayerWalkState");
            _controller.stateMachine.ChangeState(new PlayerWalkState(_controller));
        }
    }
}
