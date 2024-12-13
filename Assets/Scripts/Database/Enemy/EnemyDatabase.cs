using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

[CreateAssetMenu(fileName = "EnemyDatabase", menuName = "Game/Enemy Database")]
public class EnemyDatabase : ScriptableObject
{
    public List<EnemyData> enemy; // List of all items in the game

    // Retrieve an item by its ID
    public EnemyData GetItemById(string enemyId)
    {
        return enemy.Find(enemy => enemy.enemyId == enemyId);
    }
}
