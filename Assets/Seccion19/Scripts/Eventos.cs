using UnityEngine;
using System.Collections;

public class Eventos : MonoBehaviour {


	void Awake() /*Empieza a levantar el GameObject y va encendiendo una y otra ves los componentes (Apenas empieza el juego)*/
	{
		Debug.Log("HOLA AWAKE");
	}
		
	void Start () 
	{
		Debug.Log("HOLA START");
	}

	void Update () 
	{
		Debug.Log("HOLA UPDATE");
	}

	void OnDisable()
	{
		Debug.Log("On disable");
	}

	void OnEnable()
	{
		Debug.Log("On enable");
	}

	void OnMouseDown()
	{
		Debug.Log("On Mouse Down");
	}

	void OnMouseEnter()
	{
		Debug.Log("On Mouse Enter");
	}

	void OnMouseExit()
	{
		Debug.Log("On Mouse Exit");
	}

	void OnMouseOver()
	{
		Debug.Log("On Mouse Over");
	}




}
