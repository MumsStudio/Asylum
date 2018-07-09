using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFusionFormula : MonoBehaviour {

    GameObject fomulaP;
    public GameObject btPrefb;

    GameObject fusionFormulaDatabase;

	void Awake () {
        fusionFormulaDatabase = GameObject.FindGameObjectWithTag("FusionFormulaDatabase");
        fomulaP = GameObject.FindGameObjectWithTag("FormulaP");
        fomulaP.SetActive(false);
	}
	
	void Start() {
        
        List<FusionFormula> ffs = fusionFormulaDatabase.GetComponent<FusionFormulaStorage>().formulas;

        foreach (FusionFormula ff in ffs)
        {
            //instantiate bt on ff paneal
            GameObject bt = Instantiate(btPrefb);

            //load formula sprite into button
            bt.GetComponentInChildren<Image>().sprite = ff.sprite;
            bt.GetComponentInChildren<FormulaBt>().thisFormula = ff;
            bt.transform.SetParent(fomulaP.transform);
        }
	}

}
