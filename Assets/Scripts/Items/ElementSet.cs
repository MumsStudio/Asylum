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

    public bool CheckContain(List<ElementSet> newEles)
    {
        for (int i = 0; i < newEles.Count; i++)
        {
            if(newEles[i].ele == ele)
            {
                if (newEles[i].count >= count)
                {
                    Debug.Log("Check contain = true!");
                    return true;
                }
                else break;
                
            }
        }
        Debug.Log("Check contain false");
        return false;
    }
}
