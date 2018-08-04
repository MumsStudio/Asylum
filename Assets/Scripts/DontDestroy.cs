using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    
	void Awake () {
        gameObject.SetActive(true);
         DontDestroyOnLoad(transform.gameObject);       
    }	
}
