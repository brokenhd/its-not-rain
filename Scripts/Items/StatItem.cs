using UnityEngine;
using System.Collections;

public class StatItem : Item {

	private int health;
	private int abilityPoints;
	private int strength;
	private int abilityPower;
	private int accuracy;
	private int speed;
	private int dodge;
	private int luck;
	private int defense;

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
