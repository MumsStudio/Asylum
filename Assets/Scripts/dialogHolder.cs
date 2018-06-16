using System.Collections;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{

    //public string dialogue;
    private DMM dMAn;
    public Sprite[] DialogPortraitL;
    public Sprite[] DialogPortraitR;

    public string[] dialogueLines;

    public bool inzone = false;

    // Use this for initialization
    void Start()
    {
        dMAn = FindObjectOfType<DMM>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inzone && Input.GetKeyUp(KeyCode.Space))
        {
            if (!dMAn.dialogActive)
            {
                dMAn.dialogLines = dialogueLines;
                dMAn.currentLine = 0;
                dMAn.ShowDialogue();

                //add dialog portrait
                dMAn.imageL = DialogPortraitL;
                dMAn.imageR = DialogPortraitR;
                inzone = false;
            }
            
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inzone = true;
        }
        //return true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            inzone = false;
        }
        //return true;
    }

    /*void OnCollisionStay2D(Collider2D other)
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

                    //add dialog portrait
                    dMAn.imageL= DialogPortraitL;
                    dMAn.imageR = DialogPortraitR;
                }
            }
        }
    }*/
}
