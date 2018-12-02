using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	public float moveSpeed;
	private Animator animator;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		bool horizontalMovement = Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f;
		bool verticalMovement = Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f;
		if (horizontalMovement && verticalMovement)
		{
			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime * 0.707f, 0f, 0f));
			transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime * 0.707f, 0f));
		} else {
			if (horizontalMovement)
			{
				transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			}

			if (verticalMovement)
			{
				transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
			}
		}

		if (Input.GetAxisRaw ("Horizontal") < -0.5f && !verticalMovement) {
			spriteRenderer.flipX = true;
		} else {
			spriteRenderer.flipX = false;
		}

		animator.SetFloat("Horizontal",Input.GetAxisRaw ("Horizontal"));
		animator.SetFloat ("Vertical", Input.GetAxisRaw ("Vertical"));
	}
}
