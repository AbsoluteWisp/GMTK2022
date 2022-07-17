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
	public AudioClip roll;

	AudioSource audioSource;

	void Awake() {
		instance = this;
	}

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	public void Pickup() {
		audioSource.Stop();
		audioSource.clip = pickup;
		audioSource.Play();
	}

	public void Hurt() {
		audioSource.Stop();
		audioSource.clip = hurt;
		audioSource.Play();
	}

	public void Door() {
		audioSource.Stop();
		audioSource.clip = door;
		audioSource.Play();
	}

	public void Click() {
		audioSource.Stop();
		audioSource.clip = click;
		audioSource.Play();
	}

	public void Roll() {
		audioSource.Stop();
		audioSource.clip = roll;
		audioSource.Play();
	}
}
