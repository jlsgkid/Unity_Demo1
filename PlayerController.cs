using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject pick;
	private int score;
	public  Text count;

	private float sp = 5.0f;

	// Use this for initialization
	void Start () {
		score = 0;
		showSocre ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	void FixedUpdate(){
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody> ().AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collider){

		if(collider.gameObject.tag == "PickUp"){
			collider.gameObject.SetActive (false);
			//Destroy ();
		}

		GameObject obj = Instantiate (pick) as GameObject;
		obj.name = "PickUp" + Random.Range(10,100);
		obj.transform.position = new Vector3 (Random.Range (-8.0f, 8.0f), 0.0f, Random.Range (-8.0f, 8.0f));
		obj.gameObject.SetActive (true);
	
		score+=100;
		showSocre ();
	}

	void showSocre(){
		count.text = "score: " + score;
	}
	void Up(){

		transform.Translate(Vector3.forward * Time.deltaTime* sp);  
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//GetComponent<Rigidbody> ().AddForce (movement * speed * Time.deltaTime);
	}
	void Down(){
		transform.Translate(-Vector3.forward * Time.deltaTime * sp);  
	}
	void Left(){
		transform.Translate(Vector3.left * Time.deltaTime* sp);  
	}
	void Right(){
		transform.Translate(Vector3.right * Time.deltaTime* sp);  
	}
}
