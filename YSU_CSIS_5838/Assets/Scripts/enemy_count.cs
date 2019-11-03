using UnityEngine;

public class enemy_count : MonoBehaviour
{
	private int count;
	// Start is called before the first frame update
	void Start()
	{
		count = 0;
	}

	public void IncrementCount()
	{
		count++;
	}

	public void DecrementCount()
	{
		count--;
	}

	public int GetCount()
	{
		return count;
	}
}
