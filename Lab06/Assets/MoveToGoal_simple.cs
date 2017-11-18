using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal_simple : MonoBehaviour {

	public Transform goal;

	// Use this for initialization
	void Start () {
		UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.destination = goal.position;
	}
}
