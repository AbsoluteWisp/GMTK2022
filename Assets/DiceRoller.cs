using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceRoller : MonoBehaviour
{
	public static DiceRoller instance;
	public Dice[] dices;
	public int currentRoll = 0;
	public TextMeshProUGUI rollDisplay;

	void Awake() {
		instance = this;
	}

	void Start() {
		Roll();
	}

	public void Roll() {
		foreach (var dice in dices) {
			int value = Random.Range(0, 6);
			dice.SetNumber(value);
			dice.Enable();
		}

		currentRoll++;
		rollDisplay.text = "Roll " + currentRoll;
		AudioPlayer.instance.Roll();

		GridMovement.instance.ClearMarkers();
		DiceSelector.instance.Select(null);
	}
}
