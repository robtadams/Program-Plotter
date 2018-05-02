using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linker : MonoBehaviour {

	BoolButton bButton;
	bool old_bool;

	// Use this for initialization
	void Start () {
		GameObject swapButton = GameObject.Find("Swap Button");
		//GameObject printSprite = GameObject.Find("BoolText");
		bButton = swapButton.GetComponent<BoolButton>();
		old_bool = bButton.b;
	}

	// Update is called once per frame
	void Update () {
		if (old_bool != bButton.b){
			old_bool = bButton.b;
			PrintBool booltext = GameObject.Find("BoolText").GetComponent<PrintBool>();
			booltext.printBool(old_bool);
		}
	}
}
