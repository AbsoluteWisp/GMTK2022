using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using TMPro;

public class Spikes : MonoBehaviour {
	public static Spikes instance;
	public Tilemap spikeTilemap;
	public int maxHealth;
	public int currentHealth;
	public TextMeshProUGUI healthDisplayText;
	public Slider healthDisplaySlider;

	void Awake() {
		instance = this;
		currentHealth = maxHealth;

		healthDisplaySlider.maxValue = maxHealth;
		healthDisplaySlider.value = currentHealth;
		healthDisplayText.text = currentHealth + " / " + maxHealth;
	}

	public void TrySpikePos(Vector3Int pos) {
		if (spikeTilemap.HasTile(pos)) {
			currentHealth--;
			healthDisplaySlider.value = currentHealth;
			healthDisplayText.text = currentHealth + " / " + maxHealth;
		}

		if (currentHealth <= 0) {
			GameOver.Lose();
		}
	}
}