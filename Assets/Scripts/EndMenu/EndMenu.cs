using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {

	// Use this for initialization
	public void RetryGame () {
		SceneManager.LoadScene ("MiniGame");
	}

	public void ComeBackHome () {
		SceneManager.LoadScene ("MainMenu");
	}

	public void Exit () {
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
