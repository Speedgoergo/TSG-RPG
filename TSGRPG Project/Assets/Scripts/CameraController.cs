using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject follow;
	public float movementSpeed;
	private Camera cam;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.MoveTowards (transform.position, new Vector3 (follow.transform.position.x, follow.transform.position.y, follow.transform.position.z - 10), movementSpeed*Time.deltaTime);
	}
}
