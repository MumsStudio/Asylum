using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadbackpacktoItemlist : MonoBehaviour {

    public GameObject bagMenu;

    public List<GameObject> items;

    public List<Text> texts;

    public List<Image> images;

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
                texts[0].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[0].item.name;

                items[1].SetActive(false);
                items[2].SetActive(false);

                images[0].sprite = backpack.GetComponentInChildren<Backpack>().items[0].item.itemImage;
                break;
            case 2:
                items[0].SetActive(true);
                texts[0].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[0].item.name;

                items[1].SetActive(true);
                texts[1].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[1].item.name;

                items[2].SetActive(false);

                images[0].sprite = backpack.GetComponentInChildren<Backpack>().items[0].item.itemImage;
                images[1].sprite = backpack.GetComponentInChildren<Backpack>().items[1].item.itemImage;
                break;
            default:
                items[0].SetActive(true);
                texts[0].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[0].item.name;

                items[1].SetActive(true);
                texts[1].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[1].item.name;

                items[2].SetActive(true);
                texts[2].GetComponentInChildren<Text>().text = backpack.GetComponentInChildren<Backpack>().items[2].item.name;

                images[0].sprite = backpack.GetComponentInChildren<Backpack>().items[0].item.itemImage;
                images[1].sprite = backpack.GetComponentInChildren<Backpack>().items[1].item.itemImage;
                images[2].sprite = backpack.GetComponentInChildren<Backpack>().items[2].item.itemImage;
                break;
        }


    }
}
