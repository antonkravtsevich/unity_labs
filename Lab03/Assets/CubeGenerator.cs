using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {
    float minX;
    float maxX;
    float minZ;
    float maxZ;

    // Use this for initialization
    void Start () {
        MeshRenderer render = gameObject.GetComponent<MeshRenderer>();
 
        minX = render.bounds.min.x;
        maxX = render.bounds.max.x;
        minZ = render.bounds.min.z;
        maxZ = render.bounds.max.z;
    }   
	
	// Update is called once per frame
	void Update () {

        float newX = Random.Range(minX, maxX);
        float newZ = Random.Range(minZ, maxZ);
        float newY = gameObject.transform.position.y + 5;

        if(Input.GetKeyDown (KeyCode.Space))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(newX, newY, newZ);

            cube.AddComponent<Rigidbody>();
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(newX, newY, newZ);

            sphere.AddComponent<Rigidbody>();
        }
	}
}
