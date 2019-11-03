using UnityEngine;

public class player_enemy_collision : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("enemy"))
		{
			Destroy(this.gameObject);
			GameObject.FindGameObjectWithTag("scene").GetComponent<isGameRunning>().setOff();
		}
	}
}
