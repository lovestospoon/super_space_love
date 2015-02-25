using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Distance : MonoBehaviour {

	public GameObject endpoint;
	public GameObject player;
	public Text myText; 
	bool hasDog = false;



	void Update () {
		float dist = Vector3.Distance(player.transform.position, endpoint.transform.position); 
		Debug.Log (dist);

		if(dist >= 200f){
			myText.text = "You must find your mate!";
		}
		else if (dist >= 115f){
			myText.text = "You hear your mate\nsoftly moaning in the distance\nyou are getting closer";
		}
		else if (dist >= 75f){
			myText.text = "You hear your mate\nhowling, panting in excitment\nyou are close!";
		}
		else if (dist <= 42f){
			myText.text = "Press [SPACEBAR] to beam your mate up!";
			if(Input.GetKeyDown(KeyCode.Space)){
				hasDog = true;
			}
		}
		if(hasDog == true){
			myText.text = "You have been reunited with your mate!\nYou WIN!";

		}
	}
}
