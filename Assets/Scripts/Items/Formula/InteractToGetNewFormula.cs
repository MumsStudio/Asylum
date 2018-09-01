using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractToGetNewFormula : MonoBehaviour {

    public FusionFormula newFormula;

    public GameObject popUp;
    GameObject FusionFormulaDatabase;

    private void Start()
    {
        FusionFormulaDatabase = GameObject.FindGameObjectWithTag("FusionFormulaDatabase");
    }

    void OnTriggerStay2D(Collider2D col) 
    {
        //if interact, show popup msg and add new formula
        if(col.tag == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //add new formula to database
                FusionFormulaDatabase.GetComponent<FusionFormulaStorage>().
                    formulas.Add(newFormula);

                //popup msg will be added after new popup event be built
                //popup msg
                popUp.GetComponentInChildren<PopUpMessageController>().
                    PopUpMsg("New formula " + newFormula.item.itemName + " has been added.", 3f);
                
                Debug.Log("fffffffffffff");

                //then destory this gameobject
                Destroy(gameObject);
            }
        }
    }
}
