using UnityEngine;

public class treasure_count : MonoBehaviour
{
	private int treasureCount;
	// Start is called before the first frame update
	void Start()
	{
		treasureCount = 0;
	}

	public void incrementCount()
	{
		treasureCount++;
	}

	public void decrementCount()
	{
		treasureCount--;
	}

	public int getCount()
	{
		return treasureCount;
	}
}
