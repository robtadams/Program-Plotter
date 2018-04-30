using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class returnBoolean : MonoBehaviour {
	public Button button;
	public bool b = true;

	void Start(){
		Button btn = button.GetComponent<Button>();	
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		b = !b;
	}
}
