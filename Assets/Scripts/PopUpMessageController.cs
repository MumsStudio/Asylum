using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMessageController : MonoBehaviour {

    public float countDown;

	// Use this for initialization
	void Awake () {
        gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (countDown > 0f)
            countDown -= Time.deltaTime;
    }

    public void PopUpMsg(string msg, float time)
    {

        countDown = time;
        gameObject.GetComponentInChildren<Text>().text = msg;
        gameObject.SetActive(true);
        StartCoroutine(NeedToWait(time));
    }

    IEnumerator NeedToWait(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }

}
