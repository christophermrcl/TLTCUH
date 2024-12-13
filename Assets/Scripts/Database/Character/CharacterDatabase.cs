using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

[CreateAssetMenu(fileName = "CharacterDatabase", menuName = "Game/Character Database")]
public class CharacterDatabase : ScriptableObject
{
    public List<CharacterData> chars; // List of all items in the game

    // Retrieve an item by its ID
    public CharacterData GetItemById(string characterId)
    {
        return chars.Find(chars => chars.characterId == characterId);
    }
}
