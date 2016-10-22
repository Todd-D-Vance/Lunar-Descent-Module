using UnityEngine;
using System.Collections;

public class LockRotation : MonoBehaviour {
    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.eulerAngles = target.eulerAngles;
    }
}
