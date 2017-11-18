using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGoal : MonoBehaviour {

    public Transform weapon;
    public GameObject NavAgent;
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(weapon.position + (Vector3.up * 0.17f), weapon.forward * 10f);
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Shoot!!");
            Ray ray = new Ray(weapon.position + transform.forward + (Vector3.up * 0.17f), weapon.forward * 10f);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("New target!");
                UnityEngine.AI.NavMeshAgent agent = NavAgent.GetComponent<UnityEngine.AI.NavMeshAgent>();
                agent.destination = hit.point + hit.normal;
            }
        }
	}
}
