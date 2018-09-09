using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    private bool ObjectExist;
	void Awake () {
        gameObject.SetActive(true);
        if(!ObjectExist)
        {
            ObjectExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }	
}
