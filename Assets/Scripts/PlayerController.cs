using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {



	public float speed;
	public Text countText;
	public Text winText;
	public Text scoreText;
	public Text colorToPickUp;
	//public Text timerText;

	public float timeLeft = 5.0f;
	//public float timeStart = 3.0f;
	public Text startText; 



	private Rigidbody rb;
	private int count;
	private int number;
	private int points;


	public void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		number = Random.Range(1,4);
		switch(number)
		{
		case 1:
			colorToPickUp.text = "Color: Red";
			points = 5;
			break;
		case 2:
			colorToPickUp.text = "Color: Yellow";
			points = 5;
			break;
		case 3:
			colorToPickUp.text = "Color: Green";
			points = 5;
			break;
		case 4:
			colorToPickUp.text = "Color: Grape";
			points = 5;
			break;
		}

				
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);


			if (Input.GetKeyDown ("space") && GetComponent<Rigidbody>().transform.position.y <= 0.6250001f) {
				Vector3 jump = new Vector3 (0.0f, 200.0f, 0.0f);

				rb.AddForce (jump);
			}

		//timeStart -= Time.deltaTime;
		//startText.text = "Start in: " + (timeStart).ToString("0");
		//if (timeStart < 0)
		//{
			//Do something useful or Load a new game scene depending on your use-case
			timeLeft -= Time.deltaTime;
			startText.text = "Time left: " + (timeLeft).ToString("0");
			if(timeLeft<0)
			{
				SceneManager.LoadScene ("End");

			}

		//}




	}

	void OnTriggerEnter(Collider other) 
	{
		
		if (other.gameObject.CompareTag ( "Pick Up"))
		{
			other.gameObject.SetActive (false);
			//string colorClonado = gameObject.name.ToString + "(Clone)";
			if (other.gameObject.name == number.ToString()+ "(Clone)" | other.gameObject.name == number.ToString()) {
				count = count + points;
				scoreText.text = "Score: " + count;
				SetCountText ();
			} 
			else 
			{
				count = count - 1;
				scoreText.text = "Score: " + count;
				SetCountText ();
			}

			/*count = count + 1;
			scoreText.text = "Score: " + count;
			SetCountText ();*/
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 20)
		{
			winText.text = "You Win!";
			SceneManager.LoadScene ("MainMenu");
		}
	}
}