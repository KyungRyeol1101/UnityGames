using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnymyMove2 : MonoBehaviour {

public Transform target;
public Vector3 direction;
public float velocity;
public float accelaration;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveToTarget();
	}

	public void MoveToTarget(){
		target = GameObject.Find("Player").transform;
		direction = (target.position - transform.position).normalized;
		accelaration = 0.1f;
		velocity = (velocity+accelaration*Time.deltaTime);
		float distance = Vector3.Distance(target.position, transform.position);
		if(distance <= 10.0f){
			this.transform.position = new Vector3 (transform.position.x + (direction.x*velocity),
													transform.position.y + (direction.y*velocity),
													transform.position.z);
		}
		else{
			velocity = 0.0f;
		}
	}
}
