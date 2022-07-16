using UnityEngine;

public class DiceSelector : MonoBehaviour {
	public Dice[] dices;
	public GridMovement playerGridMovement;

	[HideInInspector] public Dice current;

	public Transform indicatorArrow;

	public static DiceSelector instance;

	void Awake() {
		instance = this;
	}

	public void Select(Dice selectedDice) {
		if (selectedDice != null) {
			if (!selectedDice.isDisabled) {
				indicatorArrow.gameObject.SetActive(true);
				current = selectedDice;
				GridMovement.instance.VisualiseDice(selectedDice);

				indicatorArrow.position = new Vector3(selectedDice.transform.position.x, indicatorArrow.position.y, indicatorArrow.position.z);
			}
		}
		else {
			indicatorArrow.gameObject.SetActive(false);
			current = null;
		}
	}

	public void DisableCurrent() {
		current.Disable();
	}
}