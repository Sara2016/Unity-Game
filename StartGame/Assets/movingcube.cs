using UnityEngine;
using System.Collections;

public class movingcube : MonoBehaviour {
	
	public float MovingSpeed;
	// Use this for initialization
	void Start () {
		MovingSpeed = 10f;
	}
		// Update is called once per frame

	// Update is called once per frame
	void Update () {
		//transform.Translate (Input.GetAxis("Horizontal")* Time.deltaTime, 0f,Input.GetAxis("Vertical")* Time.deltaTime); 
		//transform.RotateAround(transform.position ,transform.up ,90);
		/*if(Input.GetKeyDown("w"))
		transform.Translate (Input.GetAxis("Horizontal")* Time.deltaTime, 0f,0f);
		transform.eulerAngles = new Vector3 (0, 90, 90);*/
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.Translate(new Vector3(0,1,0));
			transform.Rotate (new Vector3 (10, 0, 0));
		}
		if  (Input.GetKeyDown (KeyCode.S)) {
			transform.Translate(new Vector3(0,-1,0));
			transform.Rotate (new Vector3 (10, 0, 0));
		}
			
		if  (Input.GetKeyDown (KeyCode.D)) {
			transform.Translate(new Vector3(1,0,0));
			transform.Rotate (new Vector3 (10, 0, 0));
		}
		if  (Input.GetKeyDown (KeyCode.A)) {
			transform.Translate(new Vector3(-1,0,0));
			transform.Rotate (new Vector3 (10, 0, 0));
		}

	}
}
