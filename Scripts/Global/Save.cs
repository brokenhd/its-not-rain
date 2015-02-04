using UnityEngine;
using System.Collections;

public class Save {

	public static void SaveGame() {
		PlayerPrefs.SetInt("HEROLEVEL", GameInformation.HeroLevel);
		PlayerPrefs.SetInt("HEROSTRENGTH", GameInformation.HeroStrength);
		PlayerPrefs.SetInt("HEROHEALTH", GameInformation.HeroHealth);
		PlayerPrefs.SetInt("HEROABILITYPOWER", GameInformation.HeroAbilityPower);
		PlayerPrefs.SetInt("HEROLUCK", GameInformation.HeroLuck);
		PlayerPrefs.SetInt("HEROSPEED", GameInformation.HeroSpeed);
		PlayerPrefs.SetInt("HEROACCURACY", GameInformation.HeroAccuracy);
		PlayerPrefs.SetInt("HERODEFENSE", GameInformation.HeroDefense);
		PlayerPrefs.SetInt("HERODODGE", GameInformation.HeroDodge);
		PlayerPrefs.SetInt("HEROABILITYPOINTS", GameInformation.HeroAbilityPoints);
		Debug.Log ("Saved game");
	}

}
