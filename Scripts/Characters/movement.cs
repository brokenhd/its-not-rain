using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	

	
	
	void Update () 
	{



		//Gets 
		if (Input.GetButton ("Vertical")) {
			if (Input.GetAxis ("Vertical") > 0) {
				transform.Translate (Vector3.up * Time.deltaTime, Space.World);
			} else {
				transform.Translate (-Vector3.up * Time.deltaTime, Space.World);
			}
		}
		if (Input.GetButton ("Horizontal")) {
			if (Input.GetAxis ("Horizontal") > 0) {
					transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			} else {
					transform.Translate (-Vector3.right * Time.deltaTime, Space.World);
			}
		}
	}


}
