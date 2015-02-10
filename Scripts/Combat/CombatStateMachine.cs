using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

	public enum BattleStates {
		START,
		PLAYER,
		ENEMY
	}

	private BattleStates currentState;

	void Start() {
		currentState = BattleStates.START;
	}

	void Update() {
		Debug.Log (currentState);

		switch (currentState) {
		case (BattleStates.START) :
			SetupBattle();
			break;
		case (BattleStates.PLAYER) :
			PlayerTurn();
			break;
		case (BattleStates.ENEMY) :
			EnemyTurn();
			break;
		}
	}

	void SetupBattle() {
		// get random enemy we encounted // stats and everything
		// assign party members to panels in ui
		// go to player choice
		// is boss?
		// if enemy speed > playerspeed, skip to enemy turn, set playerskipped true or false
	}

	void PlayerTurn() {
		// choose battle actions
		// which players turn is it?

		// check ability slots on current players and add to variable

		CalculateDamage();
		WinLose();
	}

	void EnemyTurn() {
		// Randomize battle actions of enemy
		// which enemies turn is it?

		CalculateDamage();
		WinLose();
	}

	void WinLose() {
		// are all of the players dead? end game
		// are all of the enemies dead? exit battle

		// experience gained

		// items dropped >> RandomLoot().Drops() >> toInventory
	}

	void CalculateDamage() {

		//calculate damage based on data from setupbattle();
		// get data
		// who is attacking who
		// miss? >> stops all damage
		// dodge? >> stops all damage

		// get special defense mods >> invulnerability and what not

		// get attributes that add to attack damage
		// is there additional modifiers? apply modifiers
		// critical? >> multiply damage by crit

		// block? >> stops % of damage

	}

	void OnGUI() {
		if(GUILayout.Button ("NEXT STATE")) {
			if(currentState == BattleStates.START) {
				currentState = BattleStates.PLAYER;
			} else if(currentState == BattleStates.PLAYER) {
				currentState = BattleStates.ENEMY;
			} else if(currentState == BattleStates.ENEMY) {
				currentState = BattleStates.PLAYER;
			}
		}
	}

}
