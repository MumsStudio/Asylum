using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadElementsIntoStomatch : MonoBehaviour {

    public List<GameObject> elements;

    public List<Image> images;

    public GameObject stomach;

    public void LoadThingsToStomach(){



        int size = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach.Count;



        switch(size){
            case 0: elements[0].SetActive(false);
                    elements[1].SetActive(false);
                    elements[2].SetActive(false);
                    break;
            case 1: elements[0].SetActive(true);
                    elements[1].SetActive(false);
                    elements[2].SetActive(false);
                    break;
            case 2:
                    elements[0].SetActive(true);
                    elements[1].SetActive(true);
                    elements[2].SetActive(false);
                    break;
            default:
                    elements[0].SetActive(true);
                    elements[1].SetActive(true);
                    elements[2].SetActive(true);
                    break;
        }
        Debug.Log("working! " + size);


        switch(size){
            case 0:
                break;
            case 1:
                images[0].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.elementImage;
                break;
            case 2:
                images[0].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.elementImage;
                images[1].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].ele.elementImage;
                break;
            default:
                images[0].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[0].ele.elementImage;
                images[1].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[1].ele.elementImage;
                images[2].sprite = stomach.GetComponentInChildren<EatIntoStomach>().elesInStomach[2].ele.elementImage;
                break;
        }

    }

}
