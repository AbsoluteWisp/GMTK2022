using UnityEngine;

public class GameOver : MonoBehaviour {
	static GameOver instance;

	public GameObject loseObject;
	public GameObject winObject;
	
	void Awake() {
		instance = this;
	}

	public static void Lose() {
		instance.loseObject.SetActive(true);
	}

	public static void Win() {
		instance.winObject.SetActive(true);
	} 
}