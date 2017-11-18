using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBrightness : MonoBehaviour
{

    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Коллизия");
        light.GetComponent<Light>().intensity= 200;

    }
}
