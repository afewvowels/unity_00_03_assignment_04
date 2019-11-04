using UnityEngine;
using UnityEngine.UI;

public class delete_enemy : MonoBehaviour
{
	private GameObject scene;
	private Text score;

	void Start()
	{
		scene = GameObject.FindGameObjectWithTag("scene");
		score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("projectile"))
		{
			Destroy(this.gameObject);
			scene.GetComponent<enemy_count>().DecrementCount();
		}
	}
}
