using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnKeyPress : MonoBehaviour {
	private void Update () {

	}
	private void OnTriggerEnter2D(Collider2D other) 
	{
		if ((other.tag == "NextSceneArea") && (Input.GetButtonDown("Submit")))
		{
			SceneManager.LoadScene("NextScene");
		}
	}
}
