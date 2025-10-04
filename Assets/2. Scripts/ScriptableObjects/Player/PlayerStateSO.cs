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
    [field:SerializeField][field:Range(0,100)] public float Speed { get; private set; }
}
[Serializable]

[CreateAssetMenu (menuName= "Player/PlayerStateSO", fileName="PlayerState")]
public class PlayerStateSO : ScriptableObject
{
    [field: SerializeField] public PlayerCondition PlayerCondition { get; private set; }
    [field: SerializeField] public PlayerMovment PlayerMovment { get; private set; }


}
