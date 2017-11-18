using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public Transform weapon;
    
	
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
                Debug.Log("Shoot at object!");
                Rigidbody r = hit.transform.gameObject.GetComponent<Rigidbody>();
                if(r != null)
                {
                    Debug.Log("Shoot at rigidbody object!!");
                    r.AddForceAtPosition(-hit.normal * 200f, hit.point);
                }
            }
        }
	}
}
