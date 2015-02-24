using UnityEngine;
using System.Collections;

public class HeroCharacter : CharacterStats {

	LevelUp levelUp;

	void Start() {
		levelUp = GetComponent<LevelUp>();

		levelUp.Level ();
	}

	public HeroCharacter() {
		CharacterName = "Hero";
		CharacterDescription = "Just a guy from a small city.";
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
