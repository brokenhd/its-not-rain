using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	ArrayList equipt = new ArrayList ();
	ArrayList ability1 = new ArrayList();
	ArrayList ability2 = new ArrayList();

	void Start () {

		GameObject ScriptManager = GameObject.Find("_ScriptManager");

		equipt.Add (ability1);
		equipt.Add (ability2);

	}



}
