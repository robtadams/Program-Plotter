using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintHello : MonoBehaviour {

	static public bool firstClick = true;
	static public Vector2 startCoord = new Vector2(0.0f, 0.0f);
	static public Vector2 endCoord = new Vector2(0.0f, 0.0f);
	static public GameObject startObject;

	public void Button_Onclick(){

		if (firstClick){
			startCoord = transform.parent.position;
			startObject = this.transform.parent.gameObject;
			firstClick = false;
		}
		else{
			endCoord = transform.parent.position;
			firstClick = true;
			transform.parent.position = startCoord;
			startObject.transform.position = endCoord;
		}

		//var pos = transform.position;
		//Debug.Log(pos);
	}
}
