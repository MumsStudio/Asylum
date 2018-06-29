using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCurrElementList : MonoBehaviour {
    public List<Element> eles;
    public GameObject stomach;
    public GameObject blockBt;

    public void LoadFormCurrToStomach()
    {
        stomach.GetComponent<EatIntoStomach>().addToStomach(eles);

        //destroy after eaten
        Destroy(blockBt);
    }
	
}
