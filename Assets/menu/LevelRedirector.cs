using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRedirector : MonoBehaviour {
	public void Load (int id) {
		PlayerPrefs.SetInt("levelID", id);
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
}
