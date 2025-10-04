using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerStateSO playerStateSO;
    public PlayerAnimate playerAnimate;

    public void Awake()
    {
        playerStateSO = new PlayerStateSO();
        playerController = GetComponent<PlayerController>();
        playerAnimate = GetComponent<PlayerAnimate>();
    }
}
