using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawblade : MonoBehaviour {

	RotateSawblade rotateSawblade;
	public float SawbladeSpeed;
	void Start () {
		rotateSawblade = gameObject.GetComponent(typeof(RotateSawblade)) as RotateSawblade;
	}
	
	void Update () {
		rotateSawblade.rotate(SawbladeSpeed);
	}
}
