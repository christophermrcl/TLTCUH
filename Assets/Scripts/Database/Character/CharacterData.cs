using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChara", menuName = "Game/Character")]
public class CharacterData : ScriptableObject
{
    public string characterId;       // Unique identifier for the item
    public string characterName;     // Name of the item
    public int healthStat;
    public int powerStat;
    public int blockStat;
    public int agilityStat;
    public int evasionStat;
    public List<MoveData> moves;
}
