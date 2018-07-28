using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCurrElementList : MonoBehaviour {
    public List<Element> eles;
    public GameObject stomach;
    public GameObject blockBt;
    GameObject eatManager;
    public GameObject popup;
    
    public void LoadFormCurrToStomach()
    {   
        //popup msg for what has been eaten
        string msg = "Element";
        foreach(Element ele in eles)
        {
            msg += " " + ele.name;
        }
        msg += " has been eaten. ";
    
        popup.SetActive(true);
        popup.GetComponent<PopUpMessageController>().PopUpMsg(msg, 3f);
            
        stomach.GetComponent<EatIntoStomach>().addToStomach(eles);
        //trun off menu
        eatManager = GameObject.FindGameObjectsWithTag("EatManager")[0];
        eatManager.GetComponent<EatZoneMenuManager>().reverseOptMenuActive();

        //destroy after eaten
        Destroy(blockBt);
    }
	
}
