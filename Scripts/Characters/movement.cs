using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	GameObject scriptManager;
	Component scriptManagerStates;

	static public float moving = 0f;
	static public float spawnRate = 5f;
	static public int spawnChance = 5;


	// Use this for initialization
	void Start () {
		scriptManager = GameObject.Find ("_ScriptManager");
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


			moving += Time.deltaTime;

		}
		if (Input.GetButton ("Horizontal")) {
			if (Input.GetAxis ("Horizontal") > 0) {
					transform.Translate (Vector3.right * Time.deltaTime, Space.World);
			} else {
					transform.Translate (-Vector3.right * Time.deltaTime, Space.World);
			}

			moving += Time.deltaTime;

		}



		if (moving > spawnRate) {
			int rand = Random.Range(0,10);
			if (rand > spawnChance){
				scriptManager.GetComponent<StateMachine>().currentState = StateMachine.States.BATTLE;

			}

			moving = 0;
		}



	}


}
