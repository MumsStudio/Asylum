using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour {

    public List<ItemSet> items;

    //add item into backpack
    public void addToBackpack(ItemObject item, int count)
    {
        bool temp = false;

        foreach(ItemSet its in items)
        {
            if (its.item == item)
            {
                its.count += count;
                temp = true;
            }
        }

        if (!temp)
        {
            items.Add(new ItemSet(item, count));
        }
    }

    public void removeFromBackpack(ItemObject item, int count)
    {
        bool temp = false;

        foreach (ItemSet its in items)
        {
            if (its.item == item && its.count>=count)
            {
                its.count -= count;
                temp = true;
            }
        }

        if (!temp)
        {
            Debug.Log("Remove from backpack failed, no enough item.");
        }
    }
}
