using UnityEngine;
using System.Collections;

public class Energia : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		
		if (other.GetComponent<Jugador>() != null)
		{
			Debug.Log(other.name);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<Jugador>() != null)
		{
			Debug.Log(other.name);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<Jugador>() != null)
		{
			Debug.Log(other.name);
		}
	}
}
