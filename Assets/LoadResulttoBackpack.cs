using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadResulttoBackpack : MonoBehaviour {

    public GameObject bagMenu;

    public List<GameObject> items;

    public GameObject backpack;

    void Awake()
    {
        bagMenu.SetActive(false);
    }

    public void LoadThingToBackpack()
    {

        int size = backpack.GetComponentInChildren<Backpack>().items.Count;

        switch (size)
        {
            case 0:
                items[0].SetActive(false);
                items[1].SetActive(false);
                items[2].SetActive(false);
                break;
            case 1:
                items[0].SetActive(true);
                items[1].SetActive(false);
                items[2].SetActive(false);
                break;
            case 2:
                items[0].SetActive(true);
                items[1].SetActive(true);
                items[2].SetActive(false);
                break;
            default:
                items[0].SetActive(true);
                items[1].SetActive(true);
                items[2].SetActive(true);
                break;
        }


    }
}
