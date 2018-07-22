using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatZoneMenuManager : MonoBehaviour {
    public bool zoneActive;
    public GameObject zoneMenu;
 
    public GameObject eatOption;
    public bool optionActive;

    void Awake()
    {
        zoneMenu = GameObject.FindGameObjectWithTag("eatzoon");
        zoneActive = true;
        reverseZoneActive();

        optionActive = true;
        reverseOptMenuActive();
    }   
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Eat"))
        {
            Debug.Log("eaten key pressed");
            reverseZoneActive();
        }
        zoneActive = zoneMenu.activeSelf;
        optionActive = eatOption.activeSelf;
    }
    
    //turn on and off for the eat zone
    public void reverseZoneActive()
    {
        if (zoneActive)
        {
            zoneActive = false;
            zoneMenu.SetActive(zoneActive);
        }
        else
        {
            zoneActive = true;
            zoneMenu.SetActive(zoneMenu);
        }
    }

    //turn on and off for the eat option menu
    public void reverseOptMenuActive()
    {
        if (optionActive)
        {
            optionActive = false;
            eatOption.SetActive(optionActive);
        }
        else
        {
            optionActive = true;
            eatOption.SetActive(optionActive);
        }
    }
}
