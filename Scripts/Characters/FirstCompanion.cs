using UnityEngine;
using System.Collections;

public class FirstCompanion : CharacterStats {

	public bool isInParty = true;
	public bool unlocked = true;

	public FirstCompanion() {

		CharacterName = "First Friend";
		CharacterDescription = "The only friend I ever had.";
		CharacterLevel = 1;
		
		Health = 100;
		AbilityPoints = 10;
		Accuracy = 5;
		Speed = 5;
		Strength = 5;
		Dodge = 5;
		Luck = 5;
		AbilityPower = 5;
		Defense = 5;

	}
}
