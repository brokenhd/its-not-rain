using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class GetEnemies : MonoBehaviour {
	void Start() {

		// Path that leads to the asset folder
		var xmlPath = Application.dataPath + "/enemies.xml";
		// Load function from the EnemyContainer class, passing in the path to which xml file to load
		var xmldat = EnemyContainer.Load(xmlPath);


		Debug.Log ("Name: " + xmldat.Enemies[0].Name);
		Debug.Log ("Health: " + xmldat.Enemies[0].Health);
		Debug.Log ("Level: " + xmldat.Enemies[0].Level);




		Debug.Log (xmldat.Enemies[1].Nested[0].Boss);
		Debug.Log (xmldat.Enemies [1].Nested [0].Name);
		Debug.Log (xmldat.Enemies [0]);


		//////////////xmldat.Enemies [0].Health = 200;
		/////////////xmldat.Enemies [0].Name = "Steven";
		//Save function - this updates and overwrites the current xml//xmldat.Save(Path.Combine(Application.dataPath, "enemies.xml"));

	}

}
