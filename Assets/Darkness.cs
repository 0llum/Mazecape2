using UnityEngine;
using System.Collections;

public class Darkness : MonoBehaviour {

	public float duration;

	public Light light;
	private float intensity;
	private float range;

	// Use this for initialization
	void Start () {
		intensity = light.intensity;
		range = light.range;
	}
	
	// Update is called once per frame
	void Update () {
		light.intensity -= Time.deltaTime / duration * intensity;
		light.range -= Time.deltaTime / duration * range;
	}
}
