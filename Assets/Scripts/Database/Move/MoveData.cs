using UnityEngine;

public enum moveTypes
{
    Attack,
    Heal,
    Buff
}

public enum targetTypes
{
    Single,
    AOE
}

public enum attackTypes
{
    Physical,
    Magic
}

public enum weaponTypes
{
    None,
    Sword,
    Staff,
    Bow
}

public enum elemTypes
{
    None,
    Flame,
    Thunder,
    Frost
}

public enum debuffList
{
    None,
    DecPower,
    DecBlock,
    DecAgility
}

public enum buffList
{
    None,
    IncPower,
    IncBlock,
    IncAgility
}

[CreateAssetMenu(fileName = "NewMove", menuName = "Game/Move")]
public class MoveData : ScriptableObject
{
    public string moveId;       // Unique identifier for the item
    public string moveName;     // Name of the item
    public moveTypes moveType;
    public targetTypes targetType;
    public attackTypes attackType;

    [Header("Attack Settings")]
    public int damagePercentage;
    public int moveRepeat;
    public int Accuracy;
    public weaponTypes weaponType;
    public elemTypes elemType;
    public debuffList debuff;
    public int debuffChance;

    [Header("Heal Settings")]
    public int healAmount;

    [Header("Buff Settings")]
    public buffList buff;
}
