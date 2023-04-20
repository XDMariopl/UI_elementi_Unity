using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Varda_paradisana : MonoBehaviour {
	//public int frameSK = 0;
	private string txt;
	public GameObject inputfield;
	public GameObject TextField;
	private string[] fragmenti = {"kys right now!","Ha funny name.","What do u need?" };
	int indekss;

	public void holdTxt()
	{
		indekss= Random.Range(0,fragmenti.Length);
		txt=inputfield.GetComponent<InputField>().text;
		if (txt == "")
		{
			TextField.GetComponent<Text>().text = "Enter ur name u dumb creature";
		}
		else
		{
			TextField.GetComponent<Text>().text = fragmenti[indekss] + " " + txt.ToUpper();
		}
	}

	// Use this for initialization
	void Start () {
		//Debug.Log("Uzsakta programa! tu esi"+frameSK+" kadra");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Kadrs: " + frameSK);
		//frameSK++;
	}
}
