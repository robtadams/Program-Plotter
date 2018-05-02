using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapObjects : MonoBehaviour {
    
	public Button yourButton;
	public Button sourceButton, destinationButton;
	static public bool firstClick, secondClick;
	public float sourceXCoord, sourceYCoord;

	void handler(){
		if (firstClick){
			/*
			sourceXCoord = transform.position.x;
			sourceYCoord = transform.position.y;
			*/
			firstClick = false;
		}
		else{
			/*
			Button btn = destinationButton.GetComponent<Button>();
			float destinationXCoord = transform.position.x;
			float destinationYCoord = transform.position.y;

			sourceButton.transform.position = new Vector2(destinationXCoord, destinationYCoord);
			destinationButton.transform.position = new Vector2(sourceXCoord, sourceYCoord);
			*/
			firstClick = true;
		}
	}

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }

	// Use this for initialization
	void Start () {
		firstClick = true;
		Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        //Button btn = sourceButton.GetComponent<Button>();
		//btn.onClick.AddListener(handler);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
