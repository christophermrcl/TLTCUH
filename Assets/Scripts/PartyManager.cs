using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PartyMember
{
    public string characterId = "0";
    public bool isPermanent = false;
    public bool weaponEquip = false;
    public bool headgearEquip = false;
    public bool armorEquip = false;
    public bool bootEquip = false;
}
public class PartyManager : MonoBehaviour
{
    public List<PartyMember> party = new List<PartyMember>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
