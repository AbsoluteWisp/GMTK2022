using UnityEngine;
using UnityEngine.Tilemaps;

public class Pickups : MonoBehaviour {
	public static Pickups instance;
	public Tilemap pickupTilemap;
	public Tilemap doorTilemap;
	public TileBase openDoorTile;
	public int collected;
	public int total;

	void Awake() {
		instance = this;
	}

	public void TryPickupPos(Vector3Int pos) {
		if (pickupTilemap.HasTile(pos)) {
			collected++;
			pickupTilemap.SetTile(pos, null);
		}
		if (collected >= total) {
			OnAllPickups();
		}
	}

	public bool TryDoorPos(Vector3Int pos) {
		if (doorTilemap.GetTile(pos) == openDoorTile) return true;
		else return false;
	}

	void OnAllPickups() {
		for (int x = doorTilemap.cellBounds.xMin; x < doorTilemap.cellBounds.xMax; x++) {
			for (int y = doorTilemap.cellBounds.yMin; y < doorTilemap.cellBounds.yMax; y++) {
				if (doorTilemap.HasTile(new Vector3Int(x, y))) {
					doorTilemap.SetTile(new Vector3Int(x, y), openDoorTile);
					return;
				}
			}
		}
	}
}