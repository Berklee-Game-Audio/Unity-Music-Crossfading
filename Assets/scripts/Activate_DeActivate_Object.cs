using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_DeActivate_Object : MonoBehaviour {

	public GameObject object01;
	public GameObject object02;
	public GameObject object03;
	public GameObject object04;

	bool playOnce = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (playOnce) {
			object01.SetActive (!object01.activeInHierarchy);
			object02.SetActive (!object02.activeInHierarchy);
			object03.SetActive (!object03.activeInHierarchy);
			object04.SetActive (!object04.activeInHierarchy);
			playOnce = !playOnce;
		}
	}
}
