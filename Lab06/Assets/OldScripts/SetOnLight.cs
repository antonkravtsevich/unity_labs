using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOnLight : MonoBehaviour
{
    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        light.GetComponent<Light>().intensity = 15;

    }
}
