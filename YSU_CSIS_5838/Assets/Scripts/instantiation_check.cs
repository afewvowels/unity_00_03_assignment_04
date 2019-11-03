using UnityEngine;

public class instantiation_check : MonoBehaviour
{
	// Toggle the collider component, when spawned if the gameobject
	// is inside another game object the collision isn't detected
	// so toggle it to force detection, used to destroy this and respawn a new one
	void Start()
	{
		if (this.GetComponent<BoxCollider>() != null)
		{
			this.GetComponent<BoxCollider>().enabled = false;
			this.GetComponent<BoxCollider>().enabled = true;
		}
		if (this.GetComponent<SphereCollider>() != null)
		{
			this.GetComponent<SphereCollider>().enabled = false;
			this.GetComponent<SphereCollider>().enabled = true;
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
