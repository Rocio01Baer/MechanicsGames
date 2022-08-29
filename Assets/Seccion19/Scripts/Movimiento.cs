using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	private Transform miTransform = null;
	public float velocidad;

	// Use this for initialization
	void Start () {

		miTransform = GetComponent<Transform>();
	
	}
	
	// Update is called once per frame
	void Update () {

		miTransform.position += new Vector3 (0,0,1 * velocidad * Time.deltaTime );
	
	}
}
