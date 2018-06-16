using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class DMM : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    public Image DialogPortraitL;
    public Image DialogPortraitR;

    public Sprite[] imageL;
    public Sprite[] imageR;
    public Sprite blank;

    public bool dialogActive;    

    public string[]dialogLines;
    public int currentLine;

    private playercontroller thePlayer;
<<<<<<< HEAD

   // public playercontroller temPlayer;
	// Use this for initialization
	void Start () {
=======


    // Use this for initialization
    void Start () {
>>>>>>> master
        thePlayer = FindObjectOfType<playercontroller>();
	}

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogActive = false;

            currentLine++;
        }
        if (currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
            thePlayer.canMove = true;
        }

        dText.text = dialogLines[currentLine];

        //add picture
        if (imageL[currentLine] == null) DialogPortraitL.sprite = blank;
        else DialogPortraitL.sprite = imageL[currentLine];
        if (imageR[currentLine] == null) DialogPortraitR.sprite = blank;
        else DialogPortraitR.sprite = imageR[currentLine];
    }

    /*public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }*/

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }
}
