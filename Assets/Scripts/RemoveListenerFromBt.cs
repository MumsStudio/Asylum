using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//this is for stomache menu's 3 element buttons to remove onclick function
//to prevent onclick function duplicate
public class RemoveListenerFromBt : MonoBehaviour {

    public Button b0;
    public Button b1;
    public Button b2;

    public void removeListener()
    {
        b0.onClick.RemoveAllListeners();
        b1.onClick.RemoveAllListeners();
        b2.onClick.RemoveAllListeners();
        //Debug.Log("element bt func removed");
    }
}
