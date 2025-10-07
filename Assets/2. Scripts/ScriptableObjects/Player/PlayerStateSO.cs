using System;
using UnityEngine;


[Serializable]
public class PlayerCondition
{
    [Header("Player Condition")]
    [field:SerializeField][field:Range(0,100)] public float MaxHp { get; private set; }
}

[Serializable]
public class PlayerMovment
{
    [Header("Player Movment")]
    [field: SerializeField] [field: Range(0, 100)] public float Speed { get; private set; } = 5f;
}

[Serializable]
public class PlayerLook
{
    [Header("Player Sensitivity")]
    [field: SerializeField] [field: Range(0, 100)] public float Sensx { get; private set; } = 0.12f;
    [field: SerializeField] [field: Range(0, 100)] public float Sensy { get; private set; } = 0.12f;

    [Header("Player Pich")]
    [field: SerializeField] [field: Range(0, 100)] public float MinPich { get; private set; } = 5f;
    [field: SerializeField] [field: Range(0, 100)] public float MaxPich { get; private set; } = 5f;
}
[Serializable]

[CreateAssetMenu (menuName= "Player/PlayerStateSO", fileName="PlayerState")]
public class PlayerStateSO : ScriptableObject
{
    [field: SerializeField] public PlayerCondition playerCondition;
    [field: SerializeField] public PlayerMovment playerMovment;
    [field: SerializeField] public PlayerLook playerLook;
}
