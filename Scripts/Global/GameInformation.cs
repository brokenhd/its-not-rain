using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	public static int HeroLevel{get;set;}
	public static int HeroStrength{get;set;}
	public static int HeroAbilityPoints{get;set;}
	public static int HeroHealth{get;set;}
	public static int HeroAbilityPower{get;set;}
	public static int HeroLuck{get;set;}
	public static int HeroAccuracy{get;set;}
	public static int HeroSpeed{get;set;}
	public static int HeroDodge{get;set;}
	public static int HeroDefense{get;set;}
}
