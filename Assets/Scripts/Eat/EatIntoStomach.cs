using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatIntoStomach : MonoBehaviour {

    public List<Element> eles;
    public int size;

    //add item into backpack
    public void addToStomach(Element ele)
    {
        if(eles.Count >= size)
            eles.RemoveAt(0);

        eles.Add(ele);
    }

    public void removeFromStomach(Element ele)
    {
        eles.Remove(ele);
    }
}
