using UnityEngine;

public class movement_camera : MonoBehaviour
{
	public float increment;
	// Start is called before the first frame update
	void Start()
	{
	}

	void FixedUpdate()
	{
		this.transform.Rotate(0.0f, increment, 0.0f, Space.World);
	}
}
