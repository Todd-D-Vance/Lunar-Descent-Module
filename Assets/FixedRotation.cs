using UnityEngine;
using System.Collections;

public class FixedRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.eulerAngles = new Vector3(-90f,0f,0f);
	}
}
