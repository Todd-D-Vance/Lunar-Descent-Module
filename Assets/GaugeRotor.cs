using UnityEngine;
using System.Collections;

public class GaugeRotor : MonoBehaviour {

    public float minValue = 0;
    public float maxValue = 100;
    public float gaugeValue = 0;
    public float direction = -1f;

    private Vector3 startRotation;

    // Use this for initialization
    void Start() {
        startRotation = transform.eulerAngles;

    }

    // Update is called once per frame
    void FixedUpdate() {
        float angle = (gaugeValue - minValue) / (maxValue - minValue) * 100f;
        transform.eulerAngles = startRotation + direction * new Vector3(angle, 0, 0);
    }
}
