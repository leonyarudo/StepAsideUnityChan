using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryItem : MonoBehaviour {
	private GameObject Camera;

	// Use this for initialization
	void Start () {
		this.Camera = GameObject.Find("Main Camera");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.Camera.transform.position.z) {
			Destroy (this.gameObject);
		}
	}
}
