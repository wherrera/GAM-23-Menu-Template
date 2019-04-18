using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneButton : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
	void Start () {
		GetComponent<Button>().onClick.AddListener(StartScene);
	}

	void StartScene() {
		 SceneManager.LoadScene(sceneName);
	}
}
