using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class TriggerAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		AudioSource myAudioSource = GetComponent<AudioSource>();
        if(myAudioSource == null)
        {
            Debug.Log("TriggerAudio: There is no AudioSource attached to this game object.");
            return;
        }

        if (myAudioSource.clip == null)
        {
            Debug.Log("TriggerAudio: There is no Clip attached to this AudioSource.");
            return;
        }

        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Stop();
            myAudioSource.Play();
        }
        else
        {
            myAudioSource.Play();
        }
	}
}
