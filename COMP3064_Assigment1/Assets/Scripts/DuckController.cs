

/**
 * File Source: DuckController.cs 
 * Author: Amanda Braz
 * Last Modified by: Amanda Braz
 * Date Last Modified: 10/20/2017
 * 
 * 
 * Program Description: 
 * 
 * Set random speed to Duck Enemy
 * Get and Transform position 
 * Measure and set random ranges to X and Y point position
 * Restart Duck once passed away from main scene
 * 
 *  
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour {
	
	//Public Variables - Accessible in Unity
	[SerializeField]
	private float minXspeed = 0.5f;
	[SerializeField]
	private float maxXspeed = 0.10f;
	[SerializeField]
	private float minYspeed = -0.2f;
	[SerializeField]
	private float maxYspeed = 0.2f;


	private Transform _transform; 
	private Vector2 _currentSpeed; 
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> (); 
		Reset ();
	}

	public void Reset(){
		
		float xSpeed = Random.Range (minXspeed, maxXspeed); 
		float ySpeed = Random.Range (minYspeed, maxYspeed); 

		_currentSpeed = new Vector2 (xSpeed, ySpeed); 

		float y = Random.Range (-4.5f, 4.5f);

		_transform.position = new Vector2 (6.45f + Random.Range (0, 6), y); 
	
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed; 

		//Apply changes
		_transform.position = _currentPosition; 

		//Restart Duck once its passed the camera border
		if (_currentPosition.x <= -6.45) {
			Reset (); 
		}
	}
}
