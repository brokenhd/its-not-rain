using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour {

	CombatStateMachine combatStateMachine;

	public enum States {
		CUTSCENE,
		BATTLE,
		MAP,
		INVENTORY
	};

	public States currentState;
	
	void Start() {

		combatStateMachine = GetComponent<CombatStateMachine>();
		currentState = States.MAP;
	}


	void Update() {
		
		switch (currentState) {
		case (States.MAP) :
			Map();
			break;
		case (States.BATTLE) :
			Battle();
			break;
		case (States.INVENTORY) :
			Inventory();
			break;
		case (States.CUTSCENE) :
			Cutscene();
			break;
		}

	}

	void Map() {


	}

	void Battle() {

		this.enabled = false;
		combatStateMachine.enabled = true;
		currentState = States.MAP;

	}

	void Inventory() {
		
		
	}

	void Cutscene() {
		
		
	}

	void OnGUI() {
		if(GUILayout.Button ("Battle")) {
			Debug.Log ("entering Battle");
			currentState = States.BATTLE;
		}
		if(GUILayout.Button ("Map")) {
			Debug.Log ("entering Map");
			
		}
		if(GUILayout.Button ("Inventory")) {
			Debug.Log ("entering Inventory");
			
		}
		if(GUILayout.Button ("Cutscene")) {
			Debug.Log ("entering Cutscene");
			
		}
	}
}
