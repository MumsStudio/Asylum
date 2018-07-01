using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ElementSet{
    public Element ele;
    public int count;    

    public ElementSet(Element ele, int count)
    {
        this.count = count;
        this.ele = ele;
    }
}
