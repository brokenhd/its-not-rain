using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour {
	public Text question;
	public Image iconImage;
	public Button Button1;
	public Text ButtonText1;
	public Button Button2;
	public Text ButtonText2;
	public Button cancelButton;
	public GameObject modalPanelObject;

	private static ModalPanel modalPanel;
	
	public static ModalPanel Instance () {
		if (!modalPanel) {
			modalPanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
			if (!modalPanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}
		
		return modalPanel;
	}


	public void Choice (string question, string textone, string texttwo, UnityAction Button1EventEvent, UnityAction Button2Event, UnityAction cancelEvent) {
		modalPanelObject.SetActive (true);
		
		Button1.onClick.RemoveAllListeners();
		ButtonText1.text = textone;
		Button1.onClick.AddListener (Button1EventEvent);
		Button1.onClick.AddListener (ClosePanel);
		
		Button2.onClick.RemoveAllListeners();
		ButtonText2.text = texttwo;
		Button2.onClick.AddListener (Button2Event);
		Button2.onClick.AddListener (ClosePanel);
		
		cancelButton.onClick.RemoveAllListeners();
		cancelButton.onClick.AddListener (cancelEvent);
		cancelButton.onClick.AddListener (ClosePanel);
		
		this.question.text = question;
		
		this.iconImage.gameObject.SetActive (true);
		Button1.gameObject.SetActive (true);
		Button2.gameObject.SetActive (true);
		cancelButton.gameObject.SetActive (true);
	}

	void ClosePanel () {
		modalPanelObject.SetActive (false);
	}

}
