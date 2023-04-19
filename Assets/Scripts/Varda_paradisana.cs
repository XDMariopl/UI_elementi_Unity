using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varda_paradisana : MonoBehaviour {
	public int frameSK = 0;

	// Use this for initialization
	void Start () {
		Debug.Log("Uzsakta programa! tu esi"+frameSK+" kadra");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Kadrs: " + frameSK);
		frameSK++;
	}
}
