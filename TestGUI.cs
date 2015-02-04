using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	void OnGUI() {
		if(GUILayout.Button ("Save")) {
			Save.SaveGame ();
		}
	}
}
