using System.Collections;
using UnityEngine;

public class QSDialogHolder : MonoBehaviour
{

    //public string dialogue;
    private DMM dMAn2;
    public Sprite[] DialogPortraitL;
    public Sprite[] DialogPortraitR;

    public string[] dialogueLines;
    public string[] questlines;
    public bool inzone = false;



    // Use this for initialization
    void Start()
    {
        dMAn2 = FindObjectOfType<DMM>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inzone && Input.GetKeyUp(KeyCode.Space) && !dMAn2.QuestStart)
        {
            if (!dMAn2.dialogActive)
            {
                dMAn2.dialogLines = dialogueLines;
                dMAn2.currentLine = 0;
                dMAn2.ShowDialogue();

                //add dialog portrait
                dMAn2.imageL = DialogPortraitL;
                dMAn2.imageR = DialogPortraitR;
                inzone = false;

            }
        }
        else if (inzone && Input.GetKeyUp(KeyCode.Space) && dMAn2.QuestStart)
        {
            if (!dMAn2.dialogActive)
            {
                dMAn2.dialogLines = questlines;
                dMAn2.currentLine = 0;
                dMAn2.ShowDialogue();

                //add dialog portrait
                dMAn2.imageL = DialogPortraitL;
                dMAn2.imageR = DialogPortraitR;
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


}
