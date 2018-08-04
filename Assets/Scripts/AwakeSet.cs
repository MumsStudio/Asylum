using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeSet : MonoBehaviour {
    public bool startWithActive;

    private void Awake()
    {
        gameObject.SetActive(true);
    }

    void Start () {
        gameObject.SetActive(startWithActive);
	}
	
}
