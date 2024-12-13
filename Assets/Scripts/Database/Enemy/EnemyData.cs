using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Game/Enemy")]

public class EnemyData : ScriptableObject
{
    public string enemyId;       // Unique identifier for the item
    public string enemyName;     // Name of the item
    public int healthStat;
    public int powerStat;
    public int blockStat;
    public int agilityStat;
    public int evasionStat;
    public List<MoveData> moves;
    public AnimatorController controller;
}
