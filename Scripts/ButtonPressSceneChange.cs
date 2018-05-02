using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPressSceneChange : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
            SceneManager.LoadScene(1);
	}
}
