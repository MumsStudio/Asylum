using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private Scene scene;
    

 
    // Update is called once per frame
    public void UpdateInfoInSavingData () {
        playerDT.reset = false;

        scene = SceneManager.GetActiveScene();
        Debug.Log("Active scene is '" + scene.name + "'.");
        
        playerDT.completeQuest = missedQuest;
        playerDT.missedQuest = missedQuest;
        playerDT.progressingQuest = progressingQuest;

        playerDT.currBackPack = currBackPack.items;
        playerDT.currEleInStomach = currEleInStomach.elesInStomach;

        
        playerDT.scene = scene.name;

        popup.GetComponent<PopUpMessageController>().PopUpMsg("Saved!!!.", 1f);

#if UNITY_EDITOR
        EditorUtility.SetDirty(playerDT);
#endif
    }
}
