using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemSet{
    public ItemObject item;
    public int count;

    public ItemSet(ItemObject item, int count)
    {
        this.item = item;
        this.count = count;
    }
}
