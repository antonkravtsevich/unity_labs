using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCollider : MonoBehaviour {

    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Коллизия");
        light.GetComponent<Light>().color = Color.red;

    }
}
