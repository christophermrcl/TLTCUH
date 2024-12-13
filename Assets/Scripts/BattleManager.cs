using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BattleCharacter
{
    public enum Role{
        Player, Enemy
    }

    public Role role;
    private int agility;
    public int characterId;
}

public class BattleManager : MonoBehaviour
{
    public EnemyPool enemyPool;
    public List<BattleCharacter> actionOrder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
