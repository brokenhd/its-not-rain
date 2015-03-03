using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	ArrayList equipt = new ArrayList ();
	ArrayList ability1 = new ArrayList();
	ArrayList ability2 = new ArrayList();
	
	
	
	private string ab1name;
	private int ab1XP;
	private int ab1RXP;
	private int ab1Level;
	private int ab1Power;

	private string ab2name;
	private int ab2XP;
	private int ab2RXP;
	private int ab2Level;
	private int ab2Power;
	
	
	
	void Start () {
		GameObject ScriptManager = GameObject.Find("_ScriptManager");
		
		ab1name = ScriptManager.GetComponent<Item>().firstAbilityName;
		ab1XP = ScriptManager.GetComponent<Item>().firstAbilitycurrentExp;
		ab1RXP = ScriptManager.GetComponent<Item>().firstAbilityexperienceRemainder;
		ab1Level = ScriptManager.GetComponent<Item>().firstAbilitycurrentLevel;
		ab1Power = ScriptManager.GetComponent<Item>().firstAbilityPower;

		ab2name = ScriptManager.GetComponent<Item>().secondAbilityName;
		ab2XP = ScriptManager.GetComponent<Item>().secondAbilitycurrentExp;
		ab2RXP = ScriptManager.GetComponent<Item>().secondAbilityexperienceRemainder;
		ab2Level = ScriptManager.GetComponent<Item>().secondAbilitycurrentLevel;
		ab2Power = ScriptManager.GetComponent<Item>().secondAbilityPower;
		
		
		ability1.Add(ab1name);
		ability1.Add(ab1XP);
		ability1.Add(ab1RXP);
		ability1.Add(ab1Level);
		ability1.Add(ab1Power);


		Debug.Log (ability1[0]);


		equipt.Add (ability1);
		equipt.Add (ability2);
		Debug.Log(equipt[0]);
	}



}
