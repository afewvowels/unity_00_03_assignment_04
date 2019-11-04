using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class delete_enemy : MonoBehaviour
{
	private GameObject scene;
	private Text score;
	private float decrement;
	private bool isHit;
	private bool isZero;

	void Start()
	{
		scene = GameObject.FindGameObjectWithTag("scene");
		score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
		decrement = 0.05f;
		isHit = false;
		isZero = false;
	}

	private void FixedUpdate()
	{
		if (isHit == true)
		{
			this.GetComponent<NavMeshAgent>().enabled = false;
			ScaleDown();
		}

		if (isZero == true)
		{
			DeleteEnemy();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("projectile"))
		{
			isHit = true;
		}
	}

	private void ScaleDown()
	{
		this.transform.Rotate(0.0f, 10.0f, 0.0f);
		this.transform.localScale -= new Vector3(decrement, decrement, decrement);

		if (this.transform.localScale.x <= 0.0f)
		{
			isZero = true;
		}
	}

	private void DeleteEnemy()
	{
		Destroy(this.gameObject);
		scene.GetComponent<enemy_count>().DecrementCount();
		score.text = Convert.ToString(Convert.ToInt32(score.text) + 5);
	}
}
