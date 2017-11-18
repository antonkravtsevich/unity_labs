﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCameraController : MonoBehaviour {
    public GameObject player;
    public float distance;

    private void LateUpdate()
    {
        transform.position = player.transform.position + Vector3.up * distance;
    }
}
