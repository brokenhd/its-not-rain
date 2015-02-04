using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour {

	public static void LoadGame() {
		GameInformation.HeroLevel = PlayerPrefs.GetInt ("HEROLEVEL");
		GameInformation.HeroStrength = PlayerPrefs.GetInt("HEROSTRENGTH");
		GameInformation.HeroHealth = PlayerPrefs.GetInt("HEROHEALTH");
		GameInformation.HeroAbilityPower = PlayerPrefs.GetInt("HEROABILITYPOWER");
		GameInformation.HeroLuck = PlayerPrefs.GetInt("HEROLUCK");
		GameInformation.HeroSpeed = PlayerPrefs.GetInt("HEROSPEED");
		GameInformation.HeroAccuracy = PlayerPrefs.GetInt("HEROACCURACY");
		GameInformation.HeroDefense = PlayerPrefs.GetInt("HERODEFENSE");
		GameInformation.HeroDodge = PlayerPrefs.GetInt("HERODODGE");
		GameInformation.HeroAbilityPoints = PlayerPrefs.GetInt("HEROABILITYPOINTS");

		if (PlayerPrefs.GetString("ItemOne") != null) {
			GameInformation.ItemOne = (Item)CharacterSerialization.Load("ItemOne");
		}

		Debug.Log ("Loaded Game");
		Debug.Log (GameInformation.HeroLevel);
		Debug.Log (GameInformation.HeroStrength);
		Debug.Log (GameInformation.HeroAbilityPower);
		Debug.Log (GameInformation.HeroDodge);
	}
}
