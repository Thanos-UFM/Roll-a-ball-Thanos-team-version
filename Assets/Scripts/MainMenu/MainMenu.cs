using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	//private int number = Random.Range(1,4);

	// Use this for initialization
	public void PlayGame () {
		
		
		SceneManager.LoadScene ("MiniGame");
	}

	public void Exit () {
		Application.Quit();
	}

	public void Instructions () {
		SceneManager.LoadScene ("Instructions");
	}

	// Update is called once per frame
	void Update () {

	}
}
