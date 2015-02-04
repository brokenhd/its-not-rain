using UnityEngine;
using System.Collections;

public class CharacterStats : MonoBehaviour {

	// Detail of character
	private string characterName;
	private string characterDescription;
	private int characterLevel;

	// Visible stats in battle
	private int health;
	private int abilityPoints;

	// Visible in stats screen
	private int accuracy;
	private int speed;
	private int strength;
	private int dodge;
	private int luck;
	private int abilityPower;
	private int defense;


	// Get and set all of that
	public string CharacterName {
		get {return characterName;}
		set {characterName = value;}
	}
	public string CharacterDescription {
		get {return characterDescription;}
		set {characterDescription = value;}
	}
	public int CharacterLevel {
		get {return characterLevel;}
		set {characterLevel = value;}
	}
	public int Health {
		get {return health;}
		set {health = value;}
	}
	public int AbilityPoints {
		get {return abilityPoints;}
		set {abilityPoints = value;}
	}
	public int Accuracy {
		get {return accuracy;}
		set {accuracy = value;}
	}
	public int Speed {
		get {return speed;}
		set {speed = value;}
	}
	public int Strength {
		get {return strength;}
		set {strength = value;}
	}
	public int Dodge {
		get {return dodge;}
		set {dodge = value;}
	}
	public int Luck {
		get {return luck;}
		set {luck = value;}
	}
	public int AbilityPower {
		get {return abilityPower;}
		set {abilityPower = value;}
	}
	public int Defense {
		get {return defense;}
		set {defense = value;}
	}

}
