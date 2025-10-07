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
        
    }

    void IState.Update()
    {
        Update();
    }

    public void FixedUpdate()
    {
    }

    public void Exit()
    {
    }

    void Update()
    {
        
    }
}
