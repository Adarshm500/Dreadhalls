using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

	void Awake() {
	}

	void Update()
	{
		if (transform.position.y < -5)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}
