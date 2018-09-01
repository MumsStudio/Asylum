using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestData : MonoBehaviour {
    public PlayerData playerSDT;
    public GameObject popup;

    public void RestD()
    {
        playerSDT.reset = true;
        popup.GetComponent<PopUpMessageController>().PopUpMsg("Rested!!!.", 1f);
    }
}

