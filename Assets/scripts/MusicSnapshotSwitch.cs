using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicSnapshotSwitch : MonoBehaviour {

	public AudioMixerSnapshot mySnapshot;
	public float fadeTime = 3.0f;
	public float delayBeforeFade = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {
		mySnapshot.TransitionTo (fadeTime);


	}

}
