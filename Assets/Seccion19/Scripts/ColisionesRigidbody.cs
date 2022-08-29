using UnityEngine;
using System.Collections;

public class ColisionesRigidbody : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if(other.collider.GetComponent<Jugador>() != null)
		{
			Debug.Log(other.collider.name);
		}
	}

	void OnCollisionStay(Collision other)
	{
		if(other.collider.GetComponent<Jugador>() != null)
		{
			Debug.Log(other.collider.name);
		}
	}

	void OnCollisionExit(Collision other)
	{
		if(other.collider.GetComponent<Jugador>() != null)
		{
			Debug.Log(other.collider.name);
		}
	}

}
