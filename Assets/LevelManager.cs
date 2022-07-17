using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelManager : MonoBehaviour {
	public Grid[] levels;
	public int[] pickupCounts;
	public Tilemap markerTilemap;

	public static int id;

	void Awake() {
		References.markerTilemap = markerTilemap;

		id = PlayerPrefs.GetInt("levelID", 0);
		LoadLevel(id);
	}

	void LoadLevel(int id) {
		foreach (var level in levels) {
			level.gameObject.SetActive(false);
		}
		levels[id].gameObject.SetActive(true);

		Pickups.collected = 0;

		var tilemaps = levels[id].GetComponentsInChildren<Tilemap>();

		foreach (var tilemap in tilemaps) {
			if (tilemap.gameObject.name == "Door") References.doorTilemap = tilemap;
			else if (tilemap.gameObject.name == "Pickups") References.pickupTilemap = tilemap;
			else if (tilemap.gameObject.name == "Ground") References.groundTilemap = tilemap;
			else if (tilemap.gameObject.name == "Spikes") References.spikeTilemap = tilemap;
		}

		// Set pickup count, or leave it up to the generator.
		if (id <= 4) {
			Pickups.total = pickupCounts[id];
		}
		else {
			Generator.instance.Generate();
		}
	}
}