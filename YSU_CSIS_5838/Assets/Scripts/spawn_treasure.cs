using UnityEngine;

public class spawn_treasure : MonoBehaviour
{
	public int maxTreasure;
	public GameObject treasure;
	public GameObject ground;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	// Alway be looking for a decremented treasure count, means player picked one up or
	// that a treasure spawned inside another game object and needed to be respawned
	private void FixedUpdate()
	{
		if (this.GetComponent<isGameRunning>().getState() && this.GetComponent<treasure_count>().getCount() <= maxTreasure)
		{
			SpawnTreasure();
		}
	}

	// Instantiate a new treasure object
	private void SpawnTreasure()
	{
		Instantiate(treasure, new Vector3(Random.Range(-50.0f, 50.0f), 0.5f, Random.Range(-50.0f, 50.0f)), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
		this.GetComponent<treasure_count>().incrementCount();
	}
}
