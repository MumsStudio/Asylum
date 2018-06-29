using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatIntoStomach : MonoBehaviour {

    public List<Element> elesInStomach;
    public int size;


    //the method triggered when player hit yes eat bt
    public void addToStomach(List<Element> currEleList)
    {
        Debug.Log("eaten");
        //add elements into stomach
        foreach (Element ele in currEleList)
        {
            if (elesInStomach.Count >= size)
                elesInStomach.RemoveAt(0);

            elesInStomach.Add(ele);
        }
    }

    public void removeFromStomach(Element ele)
    {
        elesInStomach.Remove(ele);
    }
}
