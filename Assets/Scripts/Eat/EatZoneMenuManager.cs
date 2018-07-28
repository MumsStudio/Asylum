using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatZoneMenuManager : MonoBehaviour {

    public bool eatEnable;
    public bool zoneActive;
    public GameObject zoneMenu;
 
    public GameObject eatOption;
    public bool optionActive;

    GameObject playercontroller;

    void Awake()
    {
        playercontroller = GameObject.FindGameObjectWithTag("Player");
        zoneMenu = GameObject.FindGameObjectWithTag("EatZone");
        zoneActive = true;
        reverseZoneActive();

        optionActive = true;
        reverseOptMenuActive();
        eatEnable = true;
    }   
	
	// Update is called once per frame
	void Update () {
        if (eatEnable && Input.GetButtonUp("Eat"))
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
            //turn on player movement
            playercontroller.GetComponent<playercontroller>().playerMoveEnable();
        }
        else
        {
            zoneActive = true;
            zoneMenu.SetActive(zoneMenu);
            //turn off player controller
            playercontroller.GetComponent<playercontroller>().canMove = false;
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
            //turn off player controller
            playercontroller.GetComponent<playercontroller>().canMove = false;
        }
    }
}
