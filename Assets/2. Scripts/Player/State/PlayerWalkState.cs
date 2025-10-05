using UnityEngine;

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
