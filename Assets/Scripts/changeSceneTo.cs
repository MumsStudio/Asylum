using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSceneTo : MonoBehaviour {

	public void play(string sceneTochangeTo){
		Application.LoadLevel (sceneTochangeTo);
	}

	public void quit(){
		Debug.Log ("Game Quit !!!!");
		Application.Quit ();
	}
}
