using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerSaveData : MonoBehaviour {

    public PlayerData playerDT;

    public List<int> missedQuest;
    public List<int> completeQuest;
    public List<int> progressingQuest;

    public Backpack currBackPack;
    public EatIntoStomach currEleInStomach;

    public GameObject popup;
    // Update is called once per frame
    public void UpdateInfoInSavingData () {

        playerDT.completeQuest = missedQuest;
        playerDT.missedQuest = missedQuest;
        playerDT.progressingQuest = progressingQuest;

        playerDT.currBackPack = currBackPack.items;
        playerDT.currEleInStomach = currEleInStomach.elesInStomach;

        popup.GetComponent<PopUpMessageController>().PopUpMsg("Saved!!!.", 1f);

#if UNITY_EDITOR
        EditorUtility.SetDirty(playerDT);
#endif
    }
}
