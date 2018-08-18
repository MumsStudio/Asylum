using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerReadData : MonoBehaviour
{
    
    public PlayerData playerSDT;
    public PlayerData playerRDT;
    public GameObject popup;
    

    // Update is called once per frame
    public void ReadInfoInSavingData()
    {

        playerRDT.completeQuest = playerSDT.missedQuest;
        playerRDT.missedQuest = playerSDT.missedQuest;
        playerRDT.progressingQuest = playerSDT.progressingQuest;

        playerRDT.currBackPack = playerSDT.currBackPack;
        playerRDT.currEleInStomach = playerSDT.currEleInStomach;

        popup.GetComponent<PopUpMessageController>().PopUpMsg("Read!!!.", 1f);

#if UNITY_EDITOR
        EditorUtility.SetDirty(playerSDT);
#endif
    }
}
