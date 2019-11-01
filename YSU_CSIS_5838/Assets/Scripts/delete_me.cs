using UnityEngine;

public class delete_me : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(this);
		GameObject.FindGameObjectWithTag("Scene").GetComponent<treasure_count>().decrementCount();
	}
}
