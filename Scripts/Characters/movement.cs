using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	Animator anim;
	GameObject scriptManager;
	Component scriptManagerStates;

	static public float moving = 0f;
	static public float spawnRate = 5f;
	static public int spawnChance = 5;

	bool facingRight = true;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
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

		if (Input.GetAxis ("Horizontal") != 0) {
						anim.SetFloat ("Speed", 1);
			
				} else {
						anim.SetFloat ("Speed", 0);
				}




		//Flip logic
		if (Input.GetAxis ("Horizontal") > 0 && !facingRight) 
			flip ();
		else if (Input.GetAxis ("Horizontal") < 0 && facingRight)
			flip();


		//Spawn battles based on movement
		if (moving > spawnRate) {
			int rand = Random.Range(0,10);
			if (rand > spawnChance){
				scriptManager.GetComponent<StateMachine>().currentState = StateMachine.States.BATTLE;

			}

			moving = 0;
		}

	

	}

	void flip() {
		facingRight = !facingRight;
		Vector2 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
