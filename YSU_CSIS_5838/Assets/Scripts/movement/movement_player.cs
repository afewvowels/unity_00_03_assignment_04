using UnityEngine;

public class movement_player : MonoBehaviour
{
	public float force;
	public float torque;

	private Rigidbody rb;
	// Start is called before the first frame update
	void Start()
	{
		rb = this.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void FixedUpdate()
	{

		if (Input.GetKey(KeyCode.W))
		{
			rb.AddRelativeForce(new Vector3(0.0f, 0.0f, force), ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.A))
		{
			rb.AddRelativeTorque(new Vector3(0.0f, -torque, 0.0f), ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddRelativeTorque(new Vector3(0.0f, torque, 0.0f), ForceMode.Impulse);
		}
	}
}
