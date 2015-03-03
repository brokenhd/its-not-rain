using UnityEngine;
using System.Collections;

public class LevelUp : MonoBehaviour {

	// PLAYER LEVELING
	// Reference variable that an enemy gives based on level
	// get player and all companions
	// get enemies / bosses
	CharacterStats characterStats;

	void Start() {
		// cache everything from ^
		characterStats = GetComponent<CharacterStats>();
	}

	public void Level() {

		// add the experience gained to current experience
		// check if player leveled
		// if player leveled, level up everything

		characterStats.CharacterLevel += 1;
		characterStats.Health += 10;
		characterStats.AbilityPoints += 5;
		characterStats.Accuracy += 1;
		characterStats.Speed += 1;
		characterStats.Strength += 1;
		characterStats.Dodge += 1;
		characterStats.Luck += 1;
		characterStats.AbilityPower += 1;
		characterStats.Defense += 1;

		characterStats.ToLevel += 100;
		characterStats.Experience = 0;

		Debug.Log (characterStats.CharacterLevel);

	}

}
