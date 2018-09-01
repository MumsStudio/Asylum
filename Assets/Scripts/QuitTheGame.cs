using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTheGame : MonoBehaviour {

	public void doExitGame() {
        Debug.Log("Already quit the game!");
        Application.Quit();
    }
}
