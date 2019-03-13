


/**
 * File Source: BirdCollider.cs 
 * Author: Amanda Braz
 * Last Modified by: Amanda Braz
 * Date Last Modified: 10/20/2017
 * 
 * 
 * Program Description: 
 * Defferentiate points and enemy colision
 * Set up Audio source for points 
 * Play audio when collision with coin is triggered
 * Add points when bird collides with coin 
 * Instanciate explosion when bird collides with duck enemy
 * Reset after explosion 
 * Decrease life after enemy collision
 *  
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollider : MonoBehaviour {

	[SerializeField] 
	GameController gameController; 

	[SerializeField]
	GameObject explosion; 

	private AudioSource _coinSound;

	// Use this for initialization
	void Start () {

		//Audio for points
		_coinSound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag.Equals ("Coin")) {
			Debug.Log ("Collision coin\n");
			if (_coinSound != null) {
				_coinSound.Play ();
			}

			gameController.Score+=10; //add points
			} else if (other.gameObject.tag.Equals ("Enemy")) {
				Debug.Log ("Collision Duck Enemy\n");

			Instantiate (explosion).GetComponent<Transform> ().position = other.gameObject.GetComponent<Transform> ().position; //set explosion
				other.gameObject.GetComponent<DuckController> ().Reset (); 
				gameController.Life -= 1; //decrease life
			}


		}

}

