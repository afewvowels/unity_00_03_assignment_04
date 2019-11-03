using UnityEngine;

public class start : MonoBehaviour
{
	public GameObject playerObject;

	// UI Text elements
	public GameObject startMessage;
	public GameObject backMessage;
	public GameObject score;

	private bool isGameRunning;

	// Start is called before the first frame update
	void Start()
	{
		DisplayMessage();
	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.T) && !this.GetComponent<isGameRunning>().getState())
		{
			Instantiate(playerObject, new Vector3(0.0f, 1.5f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
			startMessage.SetActive(false);
			score.SetActive(true);
			this.GetComponent<isGameRunning>().setOn();
		}

		// Display a message if the player tries to move backwards
		if (Input.GetKey(KeyCode.S) && this.GetComponent<isGameRunning>().getState())
		{
			backMessage.SetActive(true);
		}
		else
		{
			backMessage.SetActive(false);
		}
	}

	// Make this method public for when the enemy and player collide
	public void DisplayMessage()
	{
		startMessage.SetActive(true);
		backMessage.SetActive(false);
		score.SetActive(false);
	}
}
