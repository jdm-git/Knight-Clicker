using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nowy Inventory", menuName ="Inventory/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();

    public void AddItem(ItemObject _item)
    {
         Container.Add(new InventorySlot(_item));    
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public InventorySlot(ItemObject _item)
    {
        item = _item;
    }

}