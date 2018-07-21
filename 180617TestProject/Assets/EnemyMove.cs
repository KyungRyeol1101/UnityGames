using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

GameObject player;

Animator animator;
NavMeshAgent nav;
	// Use this for initialization

	void Awake(){
		player = GameObject.Find("Player");
		animator = GetComponent<Animator>();
		nav = GetComponent<NavMeshAgent>();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination(player.transform.position);
	}
}
