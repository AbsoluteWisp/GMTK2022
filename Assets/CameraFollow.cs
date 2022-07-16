using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
	public float speed;

	void LateUpdate() {
		Vector2 posPlane = transform.position;
		Vector2 playerPosPlane = player.position;

		Vector2 target = Vector2.MoveTowards(posPlane, playerPosPlane, speed * Time.deltaTime);

		transform.position = new Vector3(target.x, target.y, transform.position.z);
	}
}
