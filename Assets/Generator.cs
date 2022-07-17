using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Generator : MonoBehaviour
{
	public static Generator instance;

	public Tilemap spikes;
	public Tilemap pickups;
	public Tilemap doors;

	public TileBase spike;
	public TileBase key;
	public TileBase door;

	public Vector3Int TL;
	public Vector3Int BR;

	public int keyCount;
	public int spikeCount;

	void Awake() {
		instance = this;
	}

    public void Generate() {
		List<Vector3Int> used = new ();
		int usedKeys = 0;
		int usedSpikes = 0;

		for (int i = 0; i < (keyCount + spikeCount); i++) {
			Vector3Int randomPos;
			
			// Get a unique random position.
			// The X of BR is intentionally left out as a hardcoded spot for the door
			// Vector3Int.zero is intentionally left out to not be unfair spawning things at the player spawn
			do {
				randomPos = new Vector3Int(Random.Range(TL.x, BR.x), Random.Range(BR.y, TL.y + 1));
			} while (used.Contains(randomPos) || randomPos == Vector3Int.zero);

			if (usedKeys < keyCount) {
				usedKeys++;
				pickups.SetTile(randomPos, key);
			}
			else if (usedSpikes < spikeCount) {
				usedSpikes++;
				spikes.SetTile(randomPos, spike);
			}

			doors.SetTile(BR, door);
		}

		Pickups.total = keyCount;
	}
}