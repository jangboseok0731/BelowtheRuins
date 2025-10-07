using UnityEngine;
using UnityEngine.InputSystem;

// 조립자(Assumbler)
public class BasePlayer : MonoBehaviour
{
    public PlayerController Controller { get; private set; }
    [SerializeField] private PlayerStateSO model;
    public PlayerAnimate View{ get; private set; }
    
    private InputSystem_Actions inputActions;

    public void Awake()
    {
       
        View = GetComponent<PlayerAnimate>();
        Controller = GetComponent<PlayerController>();
        
        inputActions = new InputSystem_Actions();
        Controller.Initialize(model, inputActions,View);
        
    }
    
    private void OnEnable() => inputActions.Enable();
    private void OnDisable() => inputActions.Disable();
}
