using UnityEngine;
using System.Collections;

public class Weapon : StatItem {

	public enum WeaponTypes {
		FIST,
		GUN,
		SWORD
	}

	private WeaponTypes weaponType;
	private int elementID;

	public WeaponTypes WeaponType {
		get {return weaponType;}
		set {weaponType = value;}
	}
	public int ElementID {
		get {return elementID;}
		set {elementID = value;}
	}


}
