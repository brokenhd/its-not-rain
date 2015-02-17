using UnityEngine;
using System.Collections;

public class PartyManager : MonoBehaviour {

	// get all of the companions in the game
	FirstCompanion firstCompanion;
	
	void Start() {

		// cache the companions
		firstCompanion = GetComponent<FirstCompanion>();
		
	}	
	
	void Update() {
		
		if(firstCompanion.isInParty == true) {
			AddToParty();
		}
		
	}
	
	void AddToParty() {



	}
}
