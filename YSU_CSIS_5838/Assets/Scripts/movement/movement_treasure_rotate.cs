using UnityEngine;

public class movement_treasure_rotate : MonoBehaviour
{
	public float speed;
	// Start is called before the first frame update
	void Start()
	{
		this.transform.localEulerAngles = new Vector3(15.0f, Random.Range(0.0f, 360.0f), 0.0f);
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void FixedUpdate()
	{
		if (this.transform.localRotation.y < 360.0f)
		{
			this.transform.localEulerAngles += new Vector3(0.0f, speed, 0.0f);
		}
		else
		{
			this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
		}

	}
}
