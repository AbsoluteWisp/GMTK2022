using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
	public static AudioPlayer instance;

	public AudioClip pickup;
	public AudioClip hurt;
	public AudioClip door;
	public AudioClip click;

	AudioSource audioSource;

	void Awake() {
		instance = this;
	}

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	public void Pickup() {
		if (PlayerPrefs.GetInt("isAudio", 1) == 1) {
			audioSource.Stop();
			audioSource.clip = pickup;
			audioSource.Play();			
		}
	}

	public void Hurt() {
		if (PlayerPrefs.GetInt("isAudio", 1) == 1) {
			audioSource.Stop();
			audioSource.clip = hurt;
			audioSource.Play();			
		}
	}

	public void Door() {
		if (PlayerPrefs.GetInt("isAudio", 1) == 1) {
			audioSource.Stop();
			audioSource.clip = door;
			audioSource.Play();
		}
	}

	public void Click() {
		if (PlayerPrefs.GetInt("isAudio", 1) == 1) {
			audioSource.Stop();
			audioSource.clip = click;
			audioSource.Play();			
		}
	}
}
