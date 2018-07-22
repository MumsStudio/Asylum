using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel : MonoBehaviour {

    public GameObject button;
    private bool gogo;
    [SerializeField] private string newLevel;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player") && gogo)
        {
            Debug.Log("mmmmmmmmmmm");
            SceneManager.LoadScene(newLevel);
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
