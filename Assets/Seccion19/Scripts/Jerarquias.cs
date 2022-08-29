using UnityEngine;
using System.Collections;

public class Jerarquias : MonoBehaviour {

	public Transform miTransform;

	// Use this for initialization
	void Start () {

		miTransform = GetComponent<Transform>();

		for (int i = 0; i<miTransform.childCount;i++)
		{
			Transform hijoTransform = miTransform.GetChild(i);
			Debug.Log(hijoTransform.gameObject.name);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
