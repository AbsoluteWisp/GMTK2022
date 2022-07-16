using UnityEngine;

public class DiceSelector : MonoBehaviour {
	public Dice[] dices;
	public Dice current;
	public Transform indicatorArrow;

	public static DiceSelector instance;

	void Start() {
		instance = this;
	}

	public void Select(Dice selectedDice) {
		indicatorArrow.gameObject.SetActive(true);
		current = selectedDice;

		foreach (var dice in dices) {
			if (selectedDice != dice) {
				dice.Unselect();
			}
			else {
				indicatorArrow.position = new Vector3(dice.transform.position.x, indicatorArrow.position.y, indicatorArrow.position.z);
			}
		}
	}
}