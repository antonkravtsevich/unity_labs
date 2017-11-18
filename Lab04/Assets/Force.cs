using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(1000, 0, 0);
    }
}
