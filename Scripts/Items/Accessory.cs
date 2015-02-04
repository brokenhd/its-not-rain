using UnityEngine;
using System.Collections;

public class Accessory : MonoBehaviour {

	public enum AccessoryTypes {
		RING,
		AMULET
	}
	
	private AccessoryTypes accessoryType;
	private int elementID;
	
	public AccessoryTypes AccessoryType {
		get {return accessoryType;}
		set {accessoryType = value;}
	}
	public int ElementID {
		get {return elementID;}
		set {elementID = value;}
	}
}
