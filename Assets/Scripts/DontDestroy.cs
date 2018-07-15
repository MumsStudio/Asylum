using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    private static bool objectExists;
	// Use this for initialization
	void Start () {
        if (!objectExists)
        {
            objectExists = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
