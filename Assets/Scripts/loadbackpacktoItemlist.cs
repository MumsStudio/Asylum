using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadbackpacktoItemlist : MonoBehaviour
{

    public GameObject bagMenu;

    public List<GameObject> items;

    public List<GameObject> counts;

    public List<Text> texts;

    public List<Image> images;

    public GameObject backpack;


    void Awake()
    {
        bagMenu.SetActive(false);
    }

    public void clear()
    {
        int size = backpack.GetComponentInChildren<Backpack>().items.Count;

        for (int i = 0; i < size; i++)
        {
            items[i].SetActive(false);

        }
    }

    public void LoadThingToBackpack()
    {

        int size = backpack.GetComponentInChildren<Backpack>().items.Count;

        for (int i = 0; i < size; i++)
        {
            items[i].SetActive(false);

        }

        for (int i = 0; i < size; i++)
        {
            items[i].SetActive(true);
            texts[i].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[i].item.name;
            counts[i].GetComponentInChildren<Text>().text = "X" + "  " + backpack.GetComponentInChildren<Backpack>().items[i].count;

            images[i].sprite = backpack.GetComponentInChildren<Backpack>().items[i].item.itemImage;
        }


    }
}
