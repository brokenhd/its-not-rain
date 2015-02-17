using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

	public GameObject scriptManager;


	// Use this for initialization
	void Awake () {

		DontDestroyOnLoad(scriptManager);

	}
}
