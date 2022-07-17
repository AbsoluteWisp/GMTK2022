using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioButton : MonoBehaviour
{
	public TextMeshProUGUI text;

	void Start() {
		if (PlayerPrefs.GetInt("isAudio", 1) == 1) text.text = "Audio: OFF";
		else text.text = "Audio: ON";
	}

	public void Toggle() {
		if (PlayerPrefs.GetInt("isAudio", 1) == 1) {
			PlayerPrefs.SetInt("isAudio", 0);
			text.text = "Audio: OFF";
		}
		else {
			PlayerPrefs.SetInt("isAudio", 1);
			text.text = "Audio: ON";
		}
	}
}
