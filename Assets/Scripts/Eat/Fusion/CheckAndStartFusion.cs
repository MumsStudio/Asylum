using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAndStartFusion : MonoBehaviour {

    public GameObject stomach;
    public GameObject backpack;

    FusionFormula currFormula;
    public GameObject popup;

	public void CheckAndAddIntoBackpack () {

        currFormula = GameObject.FindGameObjectWithTag("FusionFormulaDatabase").GetComponent<FusionFormulaStorage>().currFF;

        if (currFormula == null)
        {
            Debug.Log("No Formula Loaded.");
            popup.GetComponent<PopUpMessageController>().PopUpMsg("No Formula Loaded.",2f);
        }

        else
        {
            //check if enough element
            List<ElementSet> elesInStomach = stomach.GetComponent<EatIntoStomach>().elesInStomach;

            bool res = true;

            foreach (ElementSet es in currFormula.eleP)
            {
                if (!es.CheckContain(elesInStomach))
                {
                    res = false;
                }
            }

            if (!res)
            {
                Debug.Log("No enough elements.");
                popup.GetComponent<PopUpMessageController>().PopUpMsg("No enough elements.", 2f);
            }

            //with enough elementSet, remove element from stomach, and add item into backpack
            else
            {
                //remove all needed
                foreach (ElementSet es in currFormula.eleP)
                {
                    es.RemoveFromSet(elesInStomach);
                }

                //add 1 item into backpack
                backpack.GetComponent<Backpack>().addToBackpack(currFormula.item,1);                
                popup.GetComponent<PopUpMessageController>().PopUpMsg(currFormula.item.itemName + " has been added to backpack.", 2f);
            }
        }

    }
}
