using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour {
	
	public Dictionary<string, ArrayList> Abilities = new Dictionary<string, ArrayList> ();
	ArrayList IceBall = new ArrayList ();

	void Awake(){
		IceBall.Add ("Ice Ball");
		IceBall.Add (5);

		Abilities.Add("A1", IceBall);


		//Debug.Log (Abilities["A1"]);
		//Debug.Log (Abilities ["A1"][1]);
	}

}
