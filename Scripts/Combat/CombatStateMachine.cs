using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

	public enum BattleStates {
		START,
		PLAYER,
		ENEMY,
		LOSE,
		WIN
	}

	private BattleStates currentState;

	void Start() {
		currentState = BattleStates.START;
	}

	void Update() {
		Debug.Log (currentState);

		switch (currentState) {
		case (BattleStates.START) :
			break;
		case (BattleStates.PLAYER) :
			break;
		case (BattleStates.ENEMY) :
			break;
		case (BattleStates.LOSE) :
			break;
		case (BattleStates.WIN) :
			break;
		}
	}

	void OnGUI() {
		if(GUILayout.Button ("NEXT STATE")) {
			if(currentState == BattleStates.START) {
				currentState = BattleStates.PLAYER;
			} else if(currentState == BattleStates.PLAYER) {
				currentState = BattleStates.ENEMY;
			} else if(currentState == BattleStates.ENEMY) {
				currentState = BattleStates.LOSE;
			} else if(currentState == BattleStates.LOSE) {
				currentState = BattleStates.WIN;
			} else if(currentState == BattleStates.WIN) {
				currentState = BattleStates.START;
			}
		}
	}

}
