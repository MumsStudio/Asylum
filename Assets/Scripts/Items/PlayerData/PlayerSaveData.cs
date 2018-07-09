using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerSaveData : MonoBehaviour {

    public PlayerData playerDT;

    public List<int> missedQuest;
    public List<int> completeQuest;
    public List<int> progressingQuest;

    public Backpack currBackPack;
    public EatIntoStomach currEleInStomach;

    // Update is called once per frame
    public void UpdateInfoInSavingData () {

        playerDT.completeQuest = missedQuest;
        playerDT.missedQuest = missedQuest;
        playerDT.progressingQuest = progressingQuest;

        playerDT.currBackPack = currBackPack;
        playerDT.currEleInStomach = currEleInStomach;

        EditorUtility.SetDirty(playerDT);
    }
}
