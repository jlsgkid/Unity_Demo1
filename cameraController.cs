using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	public GameObject ball;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () {

		//this.GetComponent<Transform>().position
		transform.position = ball.transform.position + offset;
	}

}
