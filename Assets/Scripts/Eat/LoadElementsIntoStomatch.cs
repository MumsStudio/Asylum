using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadElementsIntoStomatch : MonoBehaviour {

    public GameObject stomachMenu;

    public List<GameObject> elements;

    public List<Image> images;

    public GameObject stomach;

    public GameObject popUp;

    void Awake()
    {
        stomachMenu.SetActive(true);
    }
    private void Start()
    {
        stomachMenu.SetActive(false);
    }

    public void LoadThingsToStomach(){

        int size = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach.Count;

        switch(size){

            //0 element in stamche
            case 0: elements[0].SetActive(false);
                    elements[1].SetActive(false);
                    elements[2].SetActive(false);
                    break;

            //1 element in stamche
            case 1: elements[0].SetActive(true);
                elements[0].GetComponentInChildren<Text>().text =
                    stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.name+
                    " x "+ stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].count;
                    elements[1].SetActive(false);
                    elements[2].SetActive(false);
                    images[0].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.elementImage;
                //add listener to the button
                elements[0].GetComponentInChildren<Button>().onClick.AddListener(RemoveE0);
                break;

            //2 element in stamche
            case 2:
                    elements[0].SetActive(true);
                elements[0].GetComponentInChildren<Text>().text =
                    stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.name +
                    " x " + stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].count; ;
                elements[1].SetActive(true);
                elements[1].GetComponentInChildren<Text>().text =
                    stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].ele.name +
                    " x " + stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].count; ;
                elements[2].SetActive(false);
                    images[0].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.elementImage;
                    images[1].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].ele.elementImage;

                //add listener to the button
                elements[0].GetComponentInChildren<Button>().onClick.AddListener(RemoveE0);
                elements[1].GetComponentInChildren<Button>().onClick.AddListener(RemoveE1);
                break;

            //3 element in stamche
            default:
                    elements[0].SetActive(true);
                elements[0].GetComponentInChildren<Text>().text =
                    stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.name +
                    " x " + stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].count; ;
                elements[1].SetActive(true);
                elements[1].GetComponentInChildren<Text>().text =
                    stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].ele.name +
                    " x " + stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].count; ;
                elements[2].SetActive(true);
                elements[2].GetComponentInChildren<Text>().text =
                    stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[2].ele.name +
                    " x " + stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[2].count; ;
                images[0].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.elementImage;
                    images[1].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].ele.elementImage;
                    images[2].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[2].ele.elementImage;
                
                //add listener to the button
                elements[0].GetComponentInChildren<Button>().onClick.AddListener(RemoveE0);
                elements[1].GetComponentInChildren<Button>().onClick.AddListener(RemoveE1);
                elements[2].GetComponentInChildren<Button>().onClick.AddListener(RemoveE2);
                break;
        }

    }

    public void RemoveE0()
    {
        //deactive button first
        elements[0].SetActive(false);

        //inform the stamache to remove all components
        stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach.RemoveAt(0);
        popUp.GetComponent<PopUpMessageController>().PopUpMsg("Element "+elements[0].name+" has been removed from stomach.", 2f);
    }

    public void RemoveE1()
    {
        elements[1].SetActive(false);
        stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach.RemoveAt(1);
        popUp.GetComponent<PopUpMessageController>().PopUpMsg("Element " + elements[0].name + " has been removed from stomach.", 2f);
    }

    public void RemoveE2()
    {
        elements[2].SetActive(false);
        stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach.RemoveAt(2);
        popUp.GetComponent<PopUpMessageController>().PopUpMsg("Element " + elements[0].name + " has been removed from stomach.", 2f);
    }
}
