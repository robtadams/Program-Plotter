using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintBool : MonoBehaviour {

	public void printBool(bool b){
		if (b)
			GetComponent<TextMesh>().text = "True";
		else
			GetComponent<TextMesh>().text = "False";
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
