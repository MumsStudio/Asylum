using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel : MonoBehaviour {
    public GameObject stomachMenu;
    public GameObject MenuObject;
    public GameObject button;
    private bool gogo;
    [SerializeField] private string newLevel;
    // Use this for initialization

    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player") && gogo)
        {
           /* stomachMenu.SetActive(true);
            MenuObject.SetActive(true);*/
        
            SceneManager.LoadScene(newLevel);

           /* stomachMenu.SetActive(false);
            MenuObject.SetActive(false);*/
        }
    }
    void Update()
    {
        if (button == null)
        {
            gogo = true;
        }
    }

}
