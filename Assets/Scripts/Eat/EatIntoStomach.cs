using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatIntoStomach : MonoBehaviour {

    public List<ElementSet> elesInStomach;
    public int size;


    //the method triggered when player hit yes eat bt
    public void addToStomach(List<Element> currEleList)
    {
        //Debug.Log("eaten");
        //add elements into stomach
        foreach (Element ele in currEleList)
        {
            bool seted = false;

            //check if dupilicates
            foreach (ElementSet eleSetsInStomach in elesInStomach)
            {
                //if found the same element, add the amount
                if (eleSetsInStomach.ele == ele)
                {
                    eleSetsInStomach.count ++;
                    seted = true;
                    break;
                }
            }

            //when there was no duplicates
            if (!seted){
                if (elesInStomach.Count >= size){
                    //if gonna over size, remove the oldest one than add new
                    elesInStomach.RemoveAt(0);
                }
                //if not over size just add new elementset
                elesInStomach.Add(new ElementSet(ele, 1));
                //Debug.Log("new count for element " + ele.name + " in the list");
            }
        }
    }

    public void removeFromStomach(Element ele, int amount) {
    
        //check throught the things in things in stamach
        foreach (ElementSet eleSetsInStomach in elesInStomach){
            //if is the removal target, remove the amount
            if(eleSetsInStomach.ele == ele)
            {
                eleSetsInStomach.count -= amount;
            }
            //if the amount drop under 0, remove the elementset from the list
            if (eleSetsInStomach.count <= 0)
            {
                elesInStomach.Remove(eleSetsInStomach);
            }
        }
    }
}
