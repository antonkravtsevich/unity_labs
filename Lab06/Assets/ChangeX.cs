using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeX : MonoBehaviour {
	public float startZ;
	public float endZ;
	public float step;

	private bool toEnd;

	void Start()
	{
		toEnd = true;
	}

	// Update is called once per frame
	void Update () {
		float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

		if(toEnd) {
			transform.position = new Vector3(posX, posY, posZ + step);
		}
		else {
			transform.position = new Vector3(posX, posY, posZ - step);
		}
		if (toEnd & (transform.position.z >= endZ)) toEnd = false;
		if (!toEnd & (transform.position.z <= startZ)) toEnd = true;
	}
}
