using System.Collections;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{

    public string dialogue;
    private DMM dMAn;
    public string pic;

    public string[] dialogueLines;


    // Use this for initialization
    void Start()
    {
        dMAn = FindObjectOfType<DMM>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //dMAn.ShowBox(dialogue);

                if (!dMAn.dialogActive)
                {
                    dMAn.dialogLines = dialogueLines;
                    dMAn.currentLine = 0;
                    dMAn.ShowDialogue();
                }
            }
        }
    }
}
