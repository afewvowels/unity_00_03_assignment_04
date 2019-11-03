using UnityEngine;

public class movement_treasure_flee : MonoBehaviour
{
	private bool isPlayerNear;
	private GameObject player;
	private Rigidbody rb;

	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("player");
		rb = this.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (isPlayerNear)
		{
			MoveAwayFromPlayer();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
		{
			isPlayerNear = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player)
		{
			isPlayerNear = false;
		}
	}

	private void MoveAwayFromPlayer()
	{
		rb.AddRelativeForce(player.transform.forward, ForceMode.Impulse);
	}
}
