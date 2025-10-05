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
        throw new System.NotImplementedException();
    }

    void IState.Update()
    {
        Update();
    }

    public void FixedUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    void Update()
    {
        
    }
}
