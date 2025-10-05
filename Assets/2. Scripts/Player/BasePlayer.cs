using UnityEngine;
using UnityEngine.InputSystem;

// 조립자(Assumbler)
public class BasePlayer : MonoBehaviour
{
    [field: SerializeField]public PlayerController Controller { get; private set; }
    [field: SerializeField]public PlayerStateSO Model{ get; private set; }
    [field: SerializeField]public PlayerAnimate View{ get; private set; }
    
    private InputSystem_Actions inputActions;

    public void Awake()
    {
        Model = new PlayerStateSO();
        View = GetComponent<PlayerAnimate>();
        Controller = GetComponent<PlayerController>();
        
        inputActions = new InputSystem_Actions();
        Controller.Initialize(Model, inputActions,View);
        
    }
    
    private void OnEnable() => inputActions.Enable();
    private void OnDisable() => inputActions.Disable();
}
