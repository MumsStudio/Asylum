using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this class is called when the eat button is clicked
//this class read information from the contain
//give the list of elements, that can be digested into
//show the information goe from the list in the eat option box and trigger the box
public class EatSelected : MonoBehaviour {
    
    public GameObject eatOption;    

    //dk hwo to add image into the layout by script
    //using public image reference instead
    public GameObject[] eleImage =  new GameObject[5];
    public GameObject stomach;

    public Text digestHelper;
    public List<Element> currEleList;

    GameObject eatManager;
    Collider2D colid;

	void Start () {

        eatManager = GameObject.FindGameObjectWithTag("EatManager");

        colid = gameObject.GetComponentInChildren<Collider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (colid.OverlapPoint(mousePosition))
            {
                triggerEatOption();
            }
        }
    }

    private void triggerEatOption() {
        //disable eat zone
        eatManager.GetComponent<EatZoneMenuManager>().reverseZoneActive();
        eatManager.GetComponent<EatZoneMenuManager>().reverseOptMenuActive();  //enable the option box

        //add elements into currentElements list at the yes bt
        //clear the list first
        eatOption.GetComponentInChildren<LoadCurrElementList>().eles.Clear();
        eatOption.GetComponentInChildren<LoadCurrElementList>().blockBt = gameObject;

        string temp = "";

        //update info based on the given element

        //load and add elements name
        foreach (Element ele in currEleList)
        {
            temp += "   " + ele.name;
            eatOption.GetComponentInChildren<LoadCurrElementList>().eles.Add(ele);
        }
        digestHelper.text = temp;

        //load and add rune image of the elements
        //disable all image first
        foreach (GameObject img in eleImage){
           img.SetActive(false);
        }
        int counter = 0;
        Image[] tempImag = new Image[5];
        foreach (Element ele in currEleList)
        {
            tempImag[counter] = eleImage[counter].GetComponentInChildren<Image>();
            tempImag[counter].sprite = ele.elementImage;
            eleImage[counter].SetActive(true);
            counter++;
        }
    }
}
