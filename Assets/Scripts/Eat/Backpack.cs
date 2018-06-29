using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour {

    public List<ItemObject> items;

    //add item into backpack
    public void addToBackpack(ItemObject item)
    {
        items.Add(item);
    }

    public void removeFromBackpack(ItemObject item)
    {
        items.Remove(item);
    }
}
