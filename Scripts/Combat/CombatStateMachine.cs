using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

	StateMachine stateMachine;
	LevelUp levelUp;
	bool battleOver = false;
	HeroCharacter hero;
	int enemyHealth = 100;
	int xpReward = 100;

	public enum BattleStates {
		START,
		PLAYER,
		ENEMY
	}

	public BattleStates currentState;

	void Start() {
		stateMachine = GetComponent<StateMachine>();
		levelUp = GetComponent<LevelUp>();
		currentState = BattleStates.START;
		hero = GetComponent<HeroCharacter>();
	}

	void Update() {

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
		Debug.Log ("Hero entered battle");
		Debug.Log ("An enemy entered battle");
		Debug.Log ("Hero Health: " + hero.Health);
		Debug.Log ("Hero Ability Points: " + hero.AbilityPoints);
		Debug.Log ("Enemy Health: " + enemyHealth);

		currentState = BattleStates.PLAYER;
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
		if(battleOver == true) EndCombat ();

	}

	void EndCombat() {

		Debug.Log("Exiting BATTLE");
		stateMachine.enabled = true;
		this.enabled = false;

		hero.Experience += xpReward;
		if(hero.Experience >= hero.ToLevel) levelUp.Level();
		enemyHealth = 100;

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

		if(currentState == BattleStates.PLAYER) {

			if(GUILayout.Button ("Attack")) {

				enemyHealth -= 25;

				Debug.Log ("Hero hits the enemy for 25 damage!");

				if(enemyHealth > 0) {

					currentState = BattleStates.ENEMY;

				} else {

					EndCombat();
					currentState = BattleStates.START;

				}
			}

		}

		if(currentState == BattleStates.ENEMY) {

			hero.Health -= 10;
			Debug.Log ("The enemy hits you for 10 damage, you have " + hero.Health);
			currentState = BattleStates.PLAYER;

		}

		if(GUILayout.Button ("NEXT STATE")) {			
			if(currentState == BattleStates.START) {
				currentState = BattleStates.PLAYER;
			} else if(currentState == BattleStates.PLAYER) {
				currentState = BattleStates.ENEMY;
			} else if(currentState == BattleStates.ENEMY) {
				currentState = BattleStates.PLAYER;
			}
			
			Debug.Log (currentState);
		}
		if(GUILayout.Button ("End Battle")) {
			EndCombat ();
		}
	}

}
