using System.Collections;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {

    private QuestManager theQm;
    public int questNumber;

    public bool startQuest;
    public bool endQuest;
	// Use this for initialization

	void Start () {
        theQm = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!theQm.questCompleted[questNumber])
            {
                if (startQuest && !theQm.quests[questNumber].gameObject.activeSelf)
                {
                    theQm.quests[questNumber].gameObject.SetActive(true);
                    theQm.quests[questNumber].StartQuest();
                }
                if (endQuest && theQm.quests[questNumber].gameObject.activeSelf)
                {
                    theQm.quests[questNumber].EndQuest();
                }
            }
        }
    }
}
