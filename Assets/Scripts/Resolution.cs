using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Set screen resolution to 640x960, non-fullscreen
		Screen.SetResolution(2000, 2000, false);
	}
}