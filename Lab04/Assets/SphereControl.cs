using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {

    public float speed = 5;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);
        rb.AddForce(movement * speed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;
        string name = go.name;

        Debug.Log(name);

        if (name == "ForceCube")
        {
            Rigidbody rb_to = go.GetComponent<Rigidbody>();
            rb_to.AddForce(0, 1000, 0);
        }
        if (name == "RemoveCube")
        {
            Destroy(go);
        }
        if (name == "DangerCube")
        {
            Destroy(this.gameObject);
        }
    }
}
