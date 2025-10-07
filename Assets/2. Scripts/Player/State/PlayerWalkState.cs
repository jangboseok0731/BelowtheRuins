using UnityEngine;
using UnityEngine.Rendering;

public class PlayerWalkState : IState
{
    PlayerController _controller;
    public PlayerWalkState(PlayerController controller)
    {
        this._controller =  controller;
    }
    // Update is called once per frame
    public void Enter()
    {
    }
    
    public void FixedUpdate()
    {
        
    }

    public void Exit()
    {
    }

    public void Update()
    {
        Vector2 move = _controller.actions.Player.Move.ReadValue<Vector2>();
        if (move == Vector2.zero)
        {
            _controller.stateMachine.ChangeState(new PlayerIdleState(_controller));
            return;
        }

        Vector3 dir = new Vector3(move.x, 0, move.y).normalized;

        float s = _controller.model.playerMovment.Speed * Time.deltaTime;
        _controller.transform.Translate(dir * s, Space.World);

    }
    
}
