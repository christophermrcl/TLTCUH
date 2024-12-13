using System.Collections.Generic;
using UnityEngine;

public enum equipableTypes
{
    Sword,
    Staff,
    Bow,
    Headgear,
    Armor,
    Boot
}

[CreateAssetMenu(fileName = "NewEquipable", menuName = "Game/Equipable")]

public class EquipableData : ScriptableObject
{
    public string equipableId;       // Unique identifier for the item
    public string equipableName;     // Name of the item
    public equipableTypes equipableType;
    public int healthAdd;
    public int powerAdd;
    public int blockAdd;
    public int agilityAdd;
    public int evasionAdd;
    public List<MoveData> moves;
}
