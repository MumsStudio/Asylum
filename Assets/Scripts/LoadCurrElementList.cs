using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCurrElementList : MonoBehaviour {
    public List<Element> eles;
    public GameObject stomach;
    public GameObject blockBt;
    GameObject eatManager;

    public void LoadFormCurrToStomach()
    {
        stomach.GetComponent<EatIntoStomach>().addToStomach(eles);
        //trun off menu
        eatManager = GameObject.FindGameObjectsWithTag("EatManager")[0];
        eatManager.GetComponent<EatZoneMenuManager>().reverseOptMenuActive();
        //destroy after eaten
        Destroy(blockBt);
    }
	
}
