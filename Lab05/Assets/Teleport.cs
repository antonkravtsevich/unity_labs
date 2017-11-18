using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject target;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Teleport");

        GameObject go = collision.gameObject;

        go.transform.position = target.transform.position + new Vector3(0.0f, 2.0f, -2.0f);
    }
}
