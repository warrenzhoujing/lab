
using UnityEngine;

public class Death : MonoBehaviour {
	public LayerMask Bad;

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.layer == 9) {
			Die();
		}
	}
	bool FallOutOfWorld () {
		return transform.position.y < -30;
	}
	void DeathEffect() {

	}
	void Die () {
		DeathEffect();
		transform.position = new Vector2(0, 0);	
		Debug.Log("Die");
	}
	void Update () {
		if (FallOutOfWorld()) {
			Die();
		}
	}
}
