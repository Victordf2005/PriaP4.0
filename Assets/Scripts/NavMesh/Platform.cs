using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public float damp = 2;
    public float displacement = 3250f;
    float pingpong;
    private Vector3 initialPosition;

    float t;


    void Start() {
        initialPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        t = 0;
    }

    void Update() {
        pingpong = Mathf.SmoothStep(0, 1, Mathf.PingPong(t / damp, 1));
        transform.localPosition = initialPosition + transform.right * pingpong * displacement;
        t += Time.deltaTime;
    }
}
