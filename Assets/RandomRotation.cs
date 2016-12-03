using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Rotate (Vector3.up * Random.Range (0, 360));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
