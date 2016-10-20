using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Gyros : MonoBehaviour {
    public float sensitivity = 0.1f;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.angularVelocity = new Vector3(CrossPlatformInputManager.GetAxis("Vertical")*sensitivity,0, -CrossPlatformInputManager.GetAxis("Horizontal")*sensitivity);
	}
}
