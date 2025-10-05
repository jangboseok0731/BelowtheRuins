using UnityEngine;

public class PlayerRunState : IState
{
    PlayerController _controller;
    public PlayerRunState(PlayerController controller)
    {
        this._controller = controller;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
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
