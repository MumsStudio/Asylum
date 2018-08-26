using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerReadData : MonoBehaviour
{
    
    public PlayerData playerSDT;
    public PlayerData playerRDT;
    public GameObject popup;
    public GameObject playerP;

    //[SerializeField] private string currentS;

    // Update is called once per frame
    public void ReadInfoInSavingData()
    {
        //currentS = playerSDT.scene.name;

        playerRDT.completeQuest = playerSDT.missedQuest;
        playerRDT.missedQuest = playerSDT.missedQuest;
        playerRDT.progressingQuest = playerSDT.progressingQuest;

        playerRDT.currBackPack = playerSDT.currBackPack;
        playerRDT.currEleInStomach = playerSDT.currEleInStomach;

        playerRDT.scene = playerSDT.scene;
        playerP.GetComponent<Transform>().position = playerSDT.PPosition;

        if (SceneManager.GetActiveScene().name != playerSDT.scene) { 
            SceneManager.LoadScene(playerRDT.scene);
        }

        popup.GetComponent<PopUpMessageController>().PopUpMsg("Read!!!.", 1f);

#if UNITY_EDITOR
        EditorUtility.SetDirty(playerSDT);
#endif
    }
}
