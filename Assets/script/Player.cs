using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)){
			transform.position += transform.forward *Time.deltaTime * speed;
		}
		if (Input.GetKey (KeyCode.S)){
			transform.position -= transform.forward *Time.deltaTime * speed;
		}
		
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate (0f, -90f *Time.deltaTime, 0f); 
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Rotate (0f, 90f *Time.deltaTime, 0f); 
		}
	}
}
