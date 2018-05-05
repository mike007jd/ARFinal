using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatement : MonoBehaviour {

	public int scorePoint;
	public Text scoreText;
	public Text winText;
	public GameObject master;
	public GameObject winSound;
	Animator animator;

	// Use this for initialization
	public void Start(){
		animator = master.GetComponent<Animator> ();
		scorePoint = 0;
	}

	public void AddPoints(int amount)
	{

		scorePoint = scorePoint + amount;
		scoreText.text = "Points:" + scorePoint;

}

	public void SubstractPoints(int amount)
	{

		scorePoint = scorePoint - amount;
		scoreText.text = "Points:" + scorePoint;
	}

	void Update(){
		if(scorePoint == 4){

			scoreText.text = "Points:" + scorePoint;
			winText.text = "You"+" " + " Won!!";

			animator.SetTrigger("Sink");
			AudioSource audio = winSound.GetComponent<AudioSource> ();
			audio.Play ();


		}
}
}
