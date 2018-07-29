using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneTo : MonoBehaviour {
    private void Awake()
    {
        gameObject.SetActive(true);
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void play(string sceneTochangeTo){
		SceneManager.LoadScene(sceneTochangeTo);
	}

	public void quit(){
		Debug.Log ("Game Quit !!!!");
		Application.Quit ();
	}
}
