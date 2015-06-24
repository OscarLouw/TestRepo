using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {
    public Transform ball;

	// Update is called once per frame
	void Update () {
        transform.LookAt(ball);
	}
}
