using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cont : MonoBehaviour {
	public float moveSpeed = 38f;
	public float turnSpeed = 90f;
	
	
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) ) {
			transform.position += new Vector3(0f,0f,moveSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3(0f,0f,0f); 
		}
		
		else if (Input.GetKey (KeyCode.A) ) {
			transform.position += new Vector3(-moveSpeed* Time.deltaTime,0f,0f);
			transform.eulerAngles = new Vector3(0f,270f,0f); 
}
		else if (Input.GetKey (KeyCode.S) ) {
			transform.position += new Vector3(0f,0f,-moveSpeed* Time.deltaTime);
			transform.eulerAngles = new Vector3(0f,180f,0f);
		}
		else if (Input.GetKey (KeyCode.D) ) {
			transform.position += new Vector3(moveSpeed * Time.deltaTime,0f,0f);
			transform.eulerAngles = new Vector3(0f,90f,0f) ;
			}
		
		Camera.main.transform.position = transform.position + new Vector3(0f,29f,-15f);
	}
}
