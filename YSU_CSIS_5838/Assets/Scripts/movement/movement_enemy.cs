using UnityEngine;
using UnityEngine.AI;

public class movement_enemy : MonoBehaviour
{
	public float wanderDistance;
	public float wanderTime;

	private Transform target;
	private NavMeshAgent agent;
	private float timer;
	private GameObject player;

	// Start is called before the first frame update
	void Start()
	{
		// Setup
		player = GameObject.FindGameObjectWithTag("player");
		agent = this.GetComponent<NavMeshAgent>();
		timer = wanderTime;
	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;

		if (IsPlayerDetected())
		{
			// Set agent destination to player position
			agent.destination = player.transform.position;

			// Tweak speed for player detection
			this.GetComponent<NavMeshAgent>().speed = 18.0f;
			this.GetComponent<NavMeshAgent>().acceleration = 18.0f;
		}
		else if (timer >= wanderTime)
		{
			// Set agent desitination for random position
			Vector3 newPos = RandomWanderPosition(this.transform.position, wanderDistance, -1);
			agent.destination = newPos;

			// Tweak speed for wander action
			this.GetComponent<NavMeshAgent>().speed = 6.0f;
			this.GetComponent<NavMeshAgent>().acceleration = 8.0f;

			// Reset timer
			timer = 0.0f;
		}
	}

	private Vector3 RandomWanderPosition(Vector3 origin, float distance, int layermask)
	{
		Vector3 randMovement = Random.insideUnitSphere * distance;

		randMovement += origin;

		NavMeshHit navHit;

		NavMesh.SamplePosition(randMovement, out navHit, distance, layermask);

		return navHit.position;
	}

	// Use raycasting to detect player location
	private bool IsPlayerDetected()
	{
		Vector3 fwd = this.transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(this.transform.position, fwd, 8))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
