using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

[CreateAssetMenu(fileName = "MoveDatabase", menuName = "Game/Move Database")]
public class MoveDatabase : ScriptableObject
{
    public List<MoveData> moves; // List of all items in the game

    // Retrieve an item by its ID
    public MoveData GetItemById(string moveId)
    {
        return moves.Find(moves => moves.moveId == moveId);
    }
}
