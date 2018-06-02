using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    public float moveSpeed;
    private Animator anim;
	private bool playermoving;
	private Vector2 lastMove;

    private Rigidbody2D myRigidbody;

    public bool canMove;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        canMove = true;
      
	}
	
	// Update is called once per frame
	void Update () {
		playermoving = false;

        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;
        }

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));
			playermoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
			playermoving = true;
			lastMove = new Vector2 (0f, Input.GetAxisRaw("Vertical"));
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
		anim.SetBool ("playermoving", playermoving);
		anim.SetFloat ("lastMoveX", lastMove.x);
		anim.SetFloat ("lastMoveY", lastMove.y);
    }
}
