using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class PlayStinger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		AudioSource myAudioSource = GetComponent<AudioSource>();
		myAudioSource.Play ();
	}
}
