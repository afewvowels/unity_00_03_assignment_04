using UnityEngine;
using UnityEngine.UI;

public class isGameRunning : MonoBehaviour
{
	private bool isRunning;

	public Text score;
	// Start is called before the first frame update
	void Start()
	{
		//score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
		isRunning = false;
	}

	public void setOn()
	{
		isRunning = true;
	}

	public void setOff()
	{
		isRunning = false;
		GameObject[] treasures = GameObject.FindGameObjectsWithTag("treasure");
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

		foreach (GameObject treasure in treasures)
		{
			Destroy(treasure);
			this.GetComponent<treasure_count>().decrementCount();
		}

		foreach (GameObject enemy in enemies)
		{
			Destroy(enemy);
			this.GetComponent<enemy_count>().DecrementCount();
		}

		score.text = "0";

		this.GetComponent<start>().DisplayMessage();
	}

	public bool getState()
	{
		return isRunning;
	}
}
