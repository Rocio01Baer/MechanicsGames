using UnityEngine;
using System.Collections;

public class RotacionTraslacion : MonoBehaviour {


	private Transform miTransform;
	public float velocidad;
	public float velocidadRotacion;

	void Start () 
	{
		miTransform = GetComponent<Transform>();
	}

	void Update () 
	{
		miTransform.Translate(Vector3.forward * -velocidad * Time.deltaTime);
		miTransform.Rotate(-Vector3.up * velocidadRotacion * Time.deltaTime); /*UP: Rotar hacia arriba*/
	}
}
