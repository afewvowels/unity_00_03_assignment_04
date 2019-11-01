using UnityEngine;

public class isGameRunning : MonoBehaviour
{
	private bool isRunning;
	// Start is called before the first frame update
	void Start()
	{
		isRunning = false;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void setOn()
	{
		isRunning = true;
	}

	public void setOff()
	{
		isRunning = false;
	}

	public bool getState()
	{
		return isRunning;
	}
}
