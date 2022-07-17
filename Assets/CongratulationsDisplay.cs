using UnityEngine;

public class CongratulationsDisplay : MonoBehaviour {
	void OnEnable() {
		GetComponent<TMPro.TextMeshProUGUI>().text = $"<b>Congratulations!</b>\nYou passed the level in {DiceRoller.instance.currentRoll} rolls!";
	}
}
