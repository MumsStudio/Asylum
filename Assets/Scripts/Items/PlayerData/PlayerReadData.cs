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
   

    //[SerializeField] private string currentS;

    // Update is called once per frame
    public void ReadInfoInSavingData()
    {
        if (playerSDT.reset==true)
        {
            popup.GetComponent<PopUpMessageController>().PopUpMsg("No Saved Data!!!.", 1f);
        }
        else {

            playerRDT.completeQuest = playerSDT.missedQuest;
            playerRDT.missedQuest = playerSDT.missedQuest;
            playerRDT.progressingQuest = playerSDT.progressingQuest;

            playerRDT.currBackPack = playerSDT.currBackPack;
            playerRDT.currEleInStomach = playerSDT.currEleInStomach;

            playerRDT.scene = playerSDT.scene;
            
            playerRDT.reset= playerSDT.reset;

            if (SceneManager.GetActiveScene().name != playerSDT.scene) {
                SceneManager.LoadScene(playerRDT.scene);
            }

            popup.GetComponent<PopUpMessageController>().PopUpMsg("Read!!!.", 1f);

#if UNITY_EDITOR
            EditorUtility.SetDirty(playerSDT);
#endif
        }
    }
}
