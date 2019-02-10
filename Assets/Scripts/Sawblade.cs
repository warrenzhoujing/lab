using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Sawblade : MonoBehaviour {

	RotateSawblade rotateSawblade;
	public float SawbladeSpeed;
	public bool Moving;
	float count = 0;
	public Vector2 Pos1;
	public Vector2 Pos2;
	public float MoveSpeed;
	bool toPos2;
	
	
	void Start () {
		rotateSawblade = gameObject.GetComponent(typeof(RotateSawblade)) as RotateSawblade;
		toPos2 = true;
	}
	
	void Update () {
		rotateSawblade.rotate(SawbladeSpeed);
		if (Moving) {
			if (toPos2) {
				
				
				if (count > 1) {
					count = 0;
					toPos2 = false;
				} else {
					transform.position = Vector2.Lerp(Pos1, Pos2, count);
				}
				
				count += MoveSpeed * Time.deltaTime;
				
				
				
			} else {
				
				if (count > 1) {
					count = 0;
					toPos2 = true;
				} else {
					transform.position = Vector2.Lerp(Pos2, Pos1, count);
				}
				
				count += MoveSpeed * Time.deltaTime;
				
			}
			
		}
	}
}

