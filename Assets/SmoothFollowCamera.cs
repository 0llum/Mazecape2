using UnityEngine;
using System.Collections;

public class SmoothFollowCamera : MonoBehaviour {

	public Transform lookAt;
	public Vector3 offset;
	public bool smooth;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 desiredPosition = lookAt.transform.position + offset;

		if (smooth) {
			transform.position = Vector3.Lerp (transform.position, desiredPosition, speed);
		} else {
			transform.position = desiredPosition;
		}
	}
}
