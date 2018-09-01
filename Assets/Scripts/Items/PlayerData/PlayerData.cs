using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Assets/Scripts/Items/Playerdata/Player")]
public class PlayerData : ScriptableObject
{
    public List<int> missedQuest;
    public List<int> completeQuest;
    public List<int> progressingQuest;

    public List<ItemSet> currBackPack;
    public List<ElementSet> currEleInStomach;
    public Vector2 PPosition;
    public string scene;
    public bool reset;

}

