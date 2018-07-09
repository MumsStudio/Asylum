using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAndStartFusion : MonoBehaviour {

    public GameObject stomach;
    public GameObject backpack;

    FusionFormula currFormula;
    
	public void CheckAndAddIntoBackpack () {

        currFormula = GameObject.FindGameObjectWithTag("FusionFormulaDatabase").GetComponent<FusionFormulaStorage>().currFF;

        //check if enough element
        List<ElementSet> elesInStomach = stomach.GetComponent<EatIntoStomach>().elesInStomach;

        foreach(ElementSet es in currFormula.eleP)
        {
            if (es.CheckContain(elesInStomach))
            {
                //remove eles fusion to item and add to backpack
            }
        }


    }
}
