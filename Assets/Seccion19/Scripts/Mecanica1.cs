using UnityEngine;
using System.Collections;

public class Mecanica1 : MonoBehaviour {

	public GameObject miCamaraGO;
	public GameObject buscoGO;
	public GameObject[] cubos;

	// Use this for initialization
	void Start () 
	{
		Debug.Log(gameObject.name);
		Debug.Log(miCamaraGO.name);

		buscoGO = GameObject.Find("Esfera");

		cubos = GameObject.FindGameObjectsWithTag("Player");

		Debug.Log(cubos.Length);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
