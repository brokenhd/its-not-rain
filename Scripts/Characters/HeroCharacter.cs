using UnityEngine;
using System.Collections;

public class HeroCharacter : CharacterStats {

	public HeroCharacter() {
		CharacterName = "Flint";
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

	HeroCharacter heroCharacter;

//	void OnGUI() {
//		if(GUILayout.Button ("Save")) {
//			StoreHeroInfo();
//			Save.SaveGame ();
//		}
//		
//		if(GUILayout.Button ("Load")) {
//			Application.LoadLevel ("Second");
//			Load.LoadGame ();
//		}
//	}

	public void StoreHeroInfo() {
		GameInformation.HeroLevel = CharacterLevel;
		GameInformation.HeroHealth = Health;
		GameInformation.HeroAbilityPoints = AbilityPoints;
		GameInformation.HeroAccuracy = Accuracy;
		GameInformation.HeroSpeed = Speed;
		GameInformation.HeroStrength = Strength;
		GameInformation.HeroDodge = Dodge;
		GameInformation.HeroLuck = Luck;
		GameInformation.HeroAbilityPower = AbilityPower;
		GameInformation.HeroDefense = Defense;
	}
}
