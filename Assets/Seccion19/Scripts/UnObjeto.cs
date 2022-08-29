using UnityEngine;
using System.Collections;

public class UnObjeto : MonoBehaviour {

	public Pared[] arrayDeParedes;

	void Start () {
	
		arrayDeParedes = Object.FindObjectsOfType(typeof(Pared)) as Pared[];

		Debug.Log(arrayDeParedes.Length);

		Debug.Log(arrayDeParedes.ToString());

	}
	

}
