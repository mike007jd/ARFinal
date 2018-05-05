using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter : MonoBehaviour {

	public GameStatement manager;
	public GameObject statueLight;
	public GameObject correctSound;
//	private bool isPointAdded;

	void Start(){
//		GameObject theScore = GameObject.Find ("ThePlayer");
//		GameStatement gameStatement = theScore.GetComponent<GameStatement> ();
//		gameStatement.scorePoint;
//		isPointAdded = false;

	}
//
//	public void PointAdded (){
//
//		isPointAdded = true;
//
//	}

	void OnCollisionEnter(Collision hit){

		if (hit.gameObject.name == "spider") {
			manager.AddPoints (1);
			statueLight.SetActive (true);
			AudioSource audio = correctSound.GetComponent<AudioSource> ();
			audio.Play ();



//			isPointAdded = true;
		}

		if (hit.gameObject.name == "lock") {
			manager.AddPoints (1);
			statueLight.SetActive (true);
			AudioSource audio = correctSound.GetComponent<AudioSource> ();
			audio.Play ();
//			isPointAdded = true;
		}
		if (hit.gameObject.name == "rice") {
			manager.AddPoints (1);
			statueLight.SetActive (true);
			AudioSource audio = correctSound.GetComponent<AudioSource> ();
			audio.Play ();
			//			isPointAdded = true;
		}

		if (hit.gameObject.name == "peanutButter") {
			manager.AddPoints (1);
			statueLight.SetActive (true);
			AudioSource audio = correctSound.GetComponent<AudioSource> ();
			audio.Play ();
			//			isPointAdded = true;
		}
			
	}

	void OnCollisionExit(Collision hit){

		if (hit.gameObject.name == "spider") {
			manager.SubstractPoints (1);
			statueLight.SetActive (false);
			//			isPointAdded = true;
		}

		if (hit.gameObject.name == "lock") {
			manager.SubstractPoints (1);
			statueLight.SetActive (false);
			//			isPointAdded = true;
		}
		if (hit.gameObject.name == "rice") {
			manager.SubstractPoints (1);
			statueLight.SetActive (false);
			//			isPointAdded = true;
		}

		if (hit.gameObject.name == "peanutButter") {
			manager.SubstractPoints (1);
			statueLight.SetActive (false);
			//			isPointAdded = true;
		}

}
	}
