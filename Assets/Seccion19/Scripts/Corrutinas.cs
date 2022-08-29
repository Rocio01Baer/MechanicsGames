using UnityEngine;
using System.Collections;

public class Corrutinas : MonoBehaviour {

	public GameObject[] cubos;

	// Use this for initialization
	void Start () {

		cubos = GameObject.FindGameObjectsWithTag("Player");
		StartCoroutine(ApagarCubos());
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log("Hola en update");
	
	}

	IEnumerator ApagarCubos()
	{
		yield return new WaitForSeconds(2);
		cubos[0].SetActive(false);

		yield return new WaitForSeconds(2);
		cubos[1].SetActive(false);

		yield return new WaitForSeconds(2);
		cubos[2].SetActive(false);

	}
}
