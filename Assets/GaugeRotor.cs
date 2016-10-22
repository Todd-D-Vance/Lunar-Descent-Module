using UnityEngine;
using System.Collections;

public class GaugeRotor : MonoBehaviour {

    public float minValue = -50;
    public float maxValue = 50;
    public float gaugeValue = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float angle = (gaugeValue - minValue) / (maxValue - minValue) * 60f  + 65f;
        transform.eulerAngles = new Vector3(angle, 0, 0);
	}
}
