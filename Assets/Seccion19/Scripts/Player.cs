using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject paredGO;
	public Pared paredScript;

	void Start () {

		paredGO = GameObject.Find("Pared");
		paredScript = paredGO.GetComponent<Pared>();

	
	}
	
	// Update is called once per frame
	void Update () {

		if (paredScript.paredActiva == false)
		{
			paredGO.SetActive(false);
		}
	
	}
}
