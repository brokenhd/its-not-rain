using UnityEngine;
using System.Collections;

public class EnterBuilding : MonoBehaviour {

	public string areaName;
	
	void Update () {


	}

	void OnTriggerStay(Collider player) {	
		GUI.Label (new Rect(10,10,100,20), "Push E to enter");
		Debug.Log("Enter building");

		if (Input.GetButton("Use")) {
			Application.LoadLevel (areaName);
		}
	}
}
