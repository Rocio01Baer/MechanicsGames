using UnityEngine;
using System.Collections;

public class Transformaciones : MonoBehaviour {

	private Transform thisTransform = null;
	public GameObject otroGO;
	Transform transformOtroGO;

	void Start () 
	{
		thisTransform = GetComponent<Transform>();
		thisTransform.position = new Vector3(2,2,2);

		otroGO = GameObject.Find("CuboRojo");
		transformOtroGO = otroGO.GetComponent<Transform>();
		transformOtroGO.position = new Vector3(-2,-2,-2);

	}

	void Update () {


	
	}
}
