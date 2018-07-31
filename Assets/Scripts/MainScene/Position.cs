using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour {

	public float widthRate;
	public float heightRate;

	void Start () {
		float x = Screen.width * widthRate;
		float y = Screen.height * heightRate;
		gameObject.transform.position = new Vector3 (x, y);
	}
}
