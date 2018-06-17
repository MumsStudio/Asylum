using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newItem")]
public class ItemObject : ScriptableObject{

    public string itemID;
    public string itemName;
    public string description;

    public Sprite itemImage;

}
