using UnityEngine;

public class PlayerRunState : IState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
