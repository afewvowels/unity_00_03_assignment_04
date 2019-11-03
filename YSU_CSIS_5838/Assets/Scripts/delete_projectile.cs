using UnityEngine;

public class delete_projectile : MonoBehaviour
{
	public float lifetime;
	public float speed;

	private float timer;
	private float actualTime;
	void Start()
	{
		timer = 0.0f;
		actualTime = lifetime + Random.Range(-2.0f, 2.0f);
	}


	void FixedUpdate()
	{
		timer += Time.deltaTime;

		if (timer >= actualTime)
		{
			ScaleDownAndDestroy();
		}
	}

	void ScaleDownAndDestroy()
	{
		Vector3 scaleFactor = new Vector3(speed, speed, speed);

		if (this.transform.localScale.x <= 0.0f)
		{
			DestroyProjectile();
		}

		this.transform.localScale -= scaleFactor;
		this.transform.Rotate(0.0f, speed, 0.0f);
	}

	void DestroyProjectile()
	{
		Destroy(this.gameObject);
	}
}
