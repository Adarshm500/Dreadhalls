using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyAudioOnSceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (scene.name == "GameOver")
		{
			GrabPickups.scoreVariable = 0;
			Destroy(gameObject);
		}
	}

	void OnDisable()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
