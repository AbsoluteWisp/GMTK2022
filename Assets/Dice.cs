using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {
	public Sprite[] numberSprites;

	public int value;

	Image img;

	void Awake() {
		img = GetComponent<Image>();
	}

	public void SetNumber(int number) {
		if (number < 0 || number >= numberSprites.Length) {
			Debug.LogError("Incorrect number passed to display on dice!");
			return;
		}

		value = number;
		img.sprite = numberSprites[number];
	}

	public void OnClick() {
		DiceSelector.instance.Select(this);
	}

	public void Unselect() {
	}
}