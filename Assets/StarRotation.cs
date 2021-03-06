﻿using UnityEngine;
using System.Collections;

public class StarRotation : MonoBehaviour {

	public Transform star;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (star != null) {
			transform.Rotate (new Vector3 (-1, -1, 1) * Time.deltaTime * speed);
		}
	}

	void OnCollisionEnter () {
		Destroy (star.gameObject);
	}
}
