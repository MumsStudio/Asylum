using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel : MonoBehaviour {

    [SerializeField] private string newLevel;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("mmmmmmmmmmm");
            SceneManager.LoadScene(newLevel);
        }
    }

}
