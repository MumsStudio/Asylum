using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAndStartFusion : MonoBehaviour {

    public GameObject stomach;
    public GameObject backpack;

    FusionFormula currFormula;
    
	public void CheckAndAddIntoBackpack () {

        currFormula = GameObject.FindGameObjectWithTag("FusionFormulaDatabase").GetComponent<FusionFormulaStorage>().currFF;

        if (currFormula == null)
        {
            Debug.Log("No Formula Loaded.");
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
                
            }
        }

    }
}
