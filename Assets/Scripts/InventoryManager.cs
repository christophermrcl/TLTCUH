using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryList
{
    public string equipableId = "0";
    public string equipCharacterId = "0";
}

public class InventoryManager : MonoBehaviour
{
    public List<InventoryList> playerInventory = new List<InventoryList>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
