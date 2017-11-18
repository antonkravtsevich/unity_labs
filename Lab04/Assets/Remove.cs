using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;
        if(go.name != "Floor")
        {
            Destroy(collision.gameObject);
        }
    }
}
