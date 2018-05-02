using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{

	public void Button_Onclick(string scene)
	{
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}
}
