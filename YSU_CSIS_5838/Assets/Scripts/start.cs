using UnityEngine;

public class start : MonoBehaviour
{
	public GameObject playerObject;
	public GameObject startMessage;
	public GameObject backMessage;
	private bool isGameRunning;
	// Start is called before the first frame update
	void Start()
	{
		startMessage.SetActive(true);
		backMessage.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.T) && !this.GetComponent<isGameRunning>().getState())
		{
			Instantiate(playerObject, new Vector3(0.0f, 1.5f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
			startMessage.SetActive(false);
			this.GetComponent<isGameRunning>().setOn();
		}
		if (Input.GetKey(KeyCode.S) && this.GetComponent<isGameRunning>().getState())
		{
			backMessage.SetActive(true);
		}
		else
		{
			backMessage.SetActive(false);
		}
	}
}
