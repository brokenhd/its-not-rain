using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class testmodal : MonoBehaviour {
	private ModalPanel modalPanel;
	private DisplayManager displayManager;

	
	void Awake () {
		modalPanel = ModalPanel.Instance ();
		displayManager = DisplayManager.Instance ();
		

	}
	
	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestYNC () {
		modalPanel.Choice ("Do you want to spawn this sphere?", "Buy", "Sell",  () => {TestYesFunction();}, () => {TestNoFunction();}, () => {TestCancelFunction();});
		//      modalPanel.Choice ("Would you like a poke in the eye?\nHow about with a sharp stick?", myYesAction, myNoAction, myCancelAction);
	}
	
	//  These are wrapped into UnityActions
	void TestYesFunction () {
		displayManager.DisplayMessage ("Heck yeah! Yes Event!");
	}
	
	void TestNoFunction () {
		displayManager.DisplayMessage ("No way, No Event!!");
	}
	
	void TestCancelFunction () {
		displayManager.DisplayMessage ("I give up, Cancel Event!");
	}


}
