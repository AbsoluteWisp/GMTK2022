using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {
	public Sprite[] numberSprites;
	public Color disabledColor;

	public bool isDisabled { get; private set; } = false;
	public int value;

	Image img;

	void Awake() {
		img = GetComponent<Image>();
	}

	public void Enable() {
		isDisabled = false;
		img.color = Color.white;
	}

	public void Disable() {
		isDisabled = true;
		img.color = disabledColor;
	}

	public void SetNumber(int number) {
		if (number < 0 || number >= numberSprites.Length) {
			Debug.LogError("Incorrect number passed to display on dice!");
			return;
		}

		value = number + 1;
		img.sprite = numberSprites[number];
	}

	public void OnClick() {
		DiceSelector.instance.Select(this);
	}
}