using UnityEngine;
using UnityEngine.Tilemaps;

public class Pickups : MonoBehaviour {
	public static Pickups instance;
	public TileBase openDoorTile;
	public static int collected;
	public static int total;

	void Awake() {
		instance = this;
	}

	void Update() {
		print(collected + " / " + total);
	}

	public void TryPickupPos(Vector3Int pos) {
		if (References.pickupTilemap.HasTile(pos)) {
			collected++;
			References.pickupTilemap.SetTile(pos, null);
		}
		if (collected >= total) {
			OnAllPickups();
		}
	}

	public bool TryDoorPos(Vector3Int pos) {
		if (References.doorTilemap.GetTile(pos) == openDoorTile) return true;
		else return false;
	}

	void OnAllPickups() {
		for (int x =References.doorTilemap.cellBounds.xMin; x <References.doorTilemap.cellBounds.xMax; x++) {
			for (int y =References.doorTilemap.cellBounds.yMin; y <References.doorTilemap.cellBounds.yMax; y++) {
				if (References.doorTilemap.HasTile(new Vector3Int(x, y))) {
				References.doorTilemap.SetTile(new Vector3Int(x, y), openDoorTile);
					return;
				}
			}
		}
	}
}