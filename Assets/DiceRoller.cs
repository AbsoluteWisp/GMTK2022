using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
	public Dice[] dices;

	void Start() {
		Roll();
	}

	public void Roll() {
		foreach (var dice in dices) {
			int value = Random.Range(0, 6);
			dice.SetNumber(value);
			dice.Enable();
		}

		GridMovement.instance.ClearMarkers();
		DiceSelector.instance.Select(null);
	}
}
