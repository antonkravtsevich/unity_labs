using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

    public GameObject marker;

	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(0, 10, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(marker);
        Destroy(this.gameObject);
    }
}
