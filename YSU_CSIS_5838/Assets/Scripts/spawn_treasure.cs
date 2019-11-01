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

	private void FixedUpdate()
	{
		if (this.GetComponent<treasure_count>().getCount() <= maxTreasure)
		{
			SpawnTreasure();
		}
	}

	private void SpawnTreasure()
	{
		Instantiate(treasure, new Vector3(Random.Range(-50.0f, 50.0f), 0.5f, Random.Range(-50.0f, 50.0f)), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
		this.GetComponent<treasure_count>().incrementCount();
	}
}
