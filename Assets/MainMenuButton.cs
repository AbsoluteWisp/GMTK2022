using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour {
	public void SwitchToMenu() {
		SceneManager.LoadScene(0, LoadSceneMode.Single);
	}
}