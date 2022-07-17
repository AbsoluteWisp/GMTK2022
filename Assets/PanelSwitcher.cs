using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitcher : MonoBehaviour {
	public GameObject playPanel;
	public GameObject howToPanel;
	public GameObject creditsPanel;

	void Start() {
		HideAll();
	}

	public void ShowPlay() {
		HideAll();
		playPanel.SetActive(true);
	}

	public void ShowHowTo() {
		HideAll();
		howToPanel.SetActive(true);
	}

	public void ShowCredits() {
		HideAll();
		creditsPanel.SetActive(true);
	}

	void HideAll() {
		playPanel.SetActive(false);
		howToPanel.SetActive(false);
		creditsPanel.SetActive(false);
	}
}
