using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoolButton : MonoBehaviour {

	public bool b = true;
    //public Button swapButton;

	void swapBool(){
		b = !b;
		if (b)
			Debug.Log("b: True");
		else
			Debug.Log("b: False");
	}

	// Use this for initialization
	void Start () {
		Button swapButton = GameObject.Find("Swap Button").GetComponent<Button>();
        swapButton.onClick.AddListener(swapBool);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
