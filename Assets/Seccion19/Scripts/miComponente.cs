using UnityEngine;
using System.Collections;

public class miComponente : MonoBehaviour {

	public Transform transformCam;

	public BoxCollider miCollider;

	// Use this for initialization
	void Start () {

		miCollider = GetComponent<BoxCollider>();

		miCollider.enabled = false;

		Debug.Log(transformCam.position.x);

		Debug.Log(miCollider.enabled);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
