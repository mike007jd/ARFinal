using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour {
	
	public GameObject guide;
	public bool grabOff;

	public void Start(){
		grabOff = true;
	}

	public void GrabOff (){

		grabOff = true;

	}

	public void GrabOn(){
		grabOff = false;

	}
		
	void OnTriggerStay(Collider other) {

		if (grabOff == false) {

			other.GetComponentInParent<Rigidbody> ().isKinematic = true;
			other.transform.position = guide.transform.position;

		}
			

		if (grabOff == true) {
			other.GetComponentInParent<Rigidbody> ().isKinematic = false;

		}
	}

		void OnTriggerExit (Collider other){
			
		grabOff = true;
		other.GetComponentInParent<Rigidbody> ().isKinematic = false;
	}
		



}