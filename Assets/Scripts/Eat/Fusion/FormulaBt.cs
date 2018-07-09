using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormulaBt : MonoBehaviour {

    public FusionFormula thisFormula;

    GameObject fusionFormulaBt;
    GameObject fusionFormulaDatabase;
    GameObject fomulaP;

    void Awake()
    {
        fusionFormulaDatabase = GameObject.FindGameObjectWithTag("FusionFormulaDatabase");
        fusionFormulaBt = GameObject.FindGameObjectWithTag("FusionFormulaBt");
        fomulaP = GameObject.FindGameObjectWithTag("FormulaP");
    }

    public void AddCurrFusionFormula()
    {
        fomulaP = GameObject.FindGameObjectWithTag("FormulaP");

        fusionFormulaDatabase.GetComponent<FusionFormulaStorage>().currFF = gameObject.GetComponentInChildren<FormulaBt>().thisFormula;
        fusionFormulaBt.GetComponent<Image>().sprite = thisFormula.sprite;
        fomulaP.SetActive(false);
    }
}
