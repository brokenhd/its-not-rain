using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {

	public enum ArmorTypes {
		HEAD,
		CHEST,
		FEET
	}
	
	private ArmorTypes armorType;
	private int elementID;
	
	public ArmorTypes ArmorType {
		get {return armorType;}
		set {armorType = value;}
	}
	public int ElementID {
		get {return elementID;}
		set {elementID = value;}
	}
}
