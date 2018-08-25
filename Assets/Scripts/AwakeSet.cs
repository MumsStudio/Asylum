using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//to set the activation for some game objects
public class AwakeSet : MonoBehaviour {
    public bool startWithActive;

    private void Awake()
    {
        gameObject.SetActive(true);
    }

    void Start () {
        gameObject.SetActive(startWithActive);
        //Debug.Log("Set " + gameObject.name + " active " + gameObject.activeSelf);
	}
	
}
