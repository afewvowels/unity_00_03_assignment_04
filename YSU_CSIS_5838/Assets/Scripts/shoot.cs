using UnityEngine;

public class shoot : MonoBehaviour
{
	public GameObject projectile;
	public float interval;
	public float velocity;
	public float torque;

	private GameObject player;
	private Rigidbody rb;
	private float timer;
	void Start()
	{
		rb = projectile.GetComponent<Rigidbody>();
		player = GameObject.FindGameObjectWithTag("player");
		timer = 0.0f;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		timer += Time.deltaTime;

		if (Input.GetKey(KeyCode.Space) && timer >= interval)
		{
			SpawnProjectile();
			timer = 0.0f;
		}
	}

	void SpawnProjectile()
	{
		Quaternion rot = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

		GameObject proj = (GameObject)Instantiate(projectile, this.transform.position + (1.5f * this.transform.forward), rot);

		proj.GetComponent<Rigidbody>().AddRelativeForce(this.transform.forward * 100.0f, ForceMode.Impulse);
	}
}
