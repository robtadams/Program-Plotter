using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

// Sets the text mesh either to True or False, depending on the value of the input boolean
public class FalseToTrue : MonoBehaviour {

	public Button button;
	public bool b;

	void Start(){
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		swapText(b);
		b = !b;
	}

	void swapText(bool value){
		
		if (value){
			GetComponent<TextMesh>().text = "True";
		}

		else{
			GetComponent<TextMesh>().text = "False";
		}
	}
}
