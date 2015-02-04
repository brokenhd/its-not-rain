using UnityEngine;
using System.Collections;

public class Consumable : StatItem {

	public enum ConsumableTypes {
		POTION,
		FOOD,
		DRINK
	}
	
	private ConsumableTypes consumableType;
	private int elementID;
	
	public ConsumableTypes ConsumableType {
		get {return consumableType;}
		set {consumableType = value;}
	}
	public int ElementID {
		get {return elementID;}
		set {elementID = value;}
	}
}
