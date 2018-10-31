using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void ComeBackHome () {
		SceneManager.LoadScene ("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
