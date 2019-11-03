using UnityEngine;

public class spawn_enemies : MonoBehaviour
{
	public float enemyCount;
	public GameObject enemy;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Watch for a decremented count, means an enemy was spawned inside a game
	// object and needed to be respawned
	private void FixedUpdate()
	{
		if (this.GetComponent<isGameRunning>().getState() && this.GetComponent<enemy_count>().GetCount() <= enemyCount)
		{
			SpawnEnemy();
		}
	}

	private void SpawnEnemy()
	{
		Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), 0.0f, Random.Range(-50.0f, 50.0f));
		Quaternion rotation = new Quaternion(0.0f, Random.Range(0.0f, 360.0f), 0.0f, 0.0f);

		GameObject newEnemy = (GameObject)Instantiate(enemy, position, rotation);
		GameObject player = GameObject.FindGameObjectWithTag("player");

		float distanceToPlayer = Vector3.Distance(newEnemy.transform.position, player.transform.position);

		if (distanceToPlayer <= 0.0f)
		{
			Destroy(newEnemy);
			SpawnEnemy();
		}

		this.GetComponent<enemy_count>().IncrementCount();
	}
}
