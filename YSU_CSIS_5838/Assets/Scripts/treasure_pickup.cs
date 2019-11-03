using System;
using UnityEngine;
using UnityEngine.UI;

public class treasure_pickup : MonoBehaviour
{
	private Text score;

	private void Start()
	{
		score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && score != null)
		{
			if (other.gameObject.CompareTag("obstacle") || other.gameObject.CompareTag("player"))
			{
				Destroy(this.transform.parent.gameObject);
				GameObject.FindGameObjectWithTag("scene").GetComponent<treasure_count>().decrementCount();
				score.text = Convert.ToString(Convert.ToInt32(score.text) + 1);
			}
		}
	}
}
