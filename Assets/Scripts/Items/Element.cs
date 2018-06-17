using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newItem")]
public class Element : ScriptableObject
{
    public string elementID;
    public string description;
    public new string name;
    public Sprite elementImage;
}
