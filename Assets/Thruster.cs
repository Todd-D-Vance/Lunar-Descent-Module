using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Thruster : MonoBehaviour {
    public float sensitivity = 0.1f;

    public float fuel = 8200;
    public float maxThrust = 45040;
    public float specificImpulse = 3050;
    public Vector3 velocity;
    Rigidbody rb;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (CrossPlatformInputManager.GetButton("Jump") || CrossPlatformInputManager.GetButton("Fire1")) {
            thrust(0.6f);
        }
        velocity = rb.velocity;
    }

    void thrust(float fraction) {
        if (fraction > 0 && fuel > 0) {
            Vector3 force = transform.up * fraction * maxThrust;
            float dmds = (maxThrust * fraction) / Physics.gravity.magnitude/16f / specificImpulse;
            print("fuel used = " + dmds);
            fuel -= dmds;
            if (fuel > 0) {
                rb.velocity += force / (rb.mass + fuel) * Time.fixedDeltaTime;
            }
        }
    }
}
