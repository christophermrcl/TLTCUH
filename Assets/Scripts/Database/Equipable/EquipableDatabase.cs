using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

[CreateAssetMenu(fileName = "EquipableDatabase", menuName = "Game/Equipable Database")]
public class EquipableDatabase : ScriptableObject
{
    public List<EquipableData> equips; // List of all items in the game

    // Retrieve an item by its ID
    public EquipableData GetItemById(string equipableId)
    {
        return equips.Find(equips => equips.equipableId == equipableId);
    }
}
