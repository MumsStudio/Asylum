using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatSelected : MonoBehaviour {

    public Button bt;
    public GameObject eatOption;
    //public 

	void Start () {
        bt.onClick.AddListener(triggerEatOption);
    }
	
	void triggerEatOption() {
        eatOption.SetActive(true);
	}
}
