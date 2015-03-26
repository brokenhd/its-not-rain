using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	Animator anim;
	GameObject scriptManager;
	Component scriptManagerStates;

	static public float moving = 0f;
	public float maxSpeed = 2f;
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
					anim.SetBool ("down", false);
					anim.SetBool ("up", true);
					transform.Translate (Vector3.up * Time.deltaTime * maxSpeed, Space.World);
			} else {
					transform.Translate (-Vector3.up * Time.deltaTime * maxSpeed, Space.World);
					anim.SetBool ("up", false);
					anim.SetBool ("down", true);
			}


			moving += Time.deltaTime;

		} else {
			anim.SetBool ("up", false);
			anim.SetBool ("down", false);
		}
		if (Input.GetButton ("Horizontal")) {
			anim.SetBool ("left-right", true);
			if (Input.GetAxis ("Horizontal") > 0) {
					transform.Translate (Vector3.right * Time.deltaTime * maxSpeed, Space.World);
			} else {
					transform.Translate (-Vector3.right * Time.deltaTime * maxSpeed, Space.World);
			}

			moving += Time.deltaTime;

		} else {
			anim.SetBool ("left-right", false);
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
