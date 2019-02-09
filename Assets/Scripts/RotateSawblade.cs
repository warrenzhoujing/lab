using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSawblade : MonoBehaviour {
	GameObject sawblade;
	void Start() {
		sawblade = GameObject.Find("Sawblade");
	}
	public void rotate(float rs) {
		sawblade.transform.Rotate(Vector3.forward * -rs);
	}
}
