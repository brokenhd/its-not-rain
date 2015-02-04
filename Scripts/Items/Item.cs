﻿using UnityEngine;
using System.Collections;

public class Item {

	private string itemName;
	private string itemDescription;
	private int itemID;

	public enum ItemTypes {
		ARMOR,
		WEAPON,
		CONSUMABLE,
		ACCESSORY
	}

	private ItemTypes itemType;

	public string ItemName {
		get {return itemName;}
		set {itemName = value;}
	}
	public string ItemDescription {
		get {return itemDescription;}
		set {itemDescription = value;}
	}
	public int ItemID {
		get {return itemID;}
		set {itemID = value;}
	}
	public ItemTypes ItemType {
		get {return itemType;}
		set {itemType = value;}
	}
}
