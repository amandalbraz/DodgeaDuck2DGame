
/**
 * File Source: BirdController.cs 
 * Author: Amanda Braz
 * Last Modified by: Amanda Braz
 * Date Last Modified: 10/20/2017
 * 
 * 
 * Program Description: 
 * Get and Transform Bird position
 * Enable Standard Key Controls
 * Check Game Camera Boudaries and apply them to Bird controls
 * 
 *  
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	//Public Variables - Accessible from Unity 
	[SerializeField]
	private float speed = 0.5f; 
	[SerializeField]
	private float upY;
	[SerializeField]
	private float downY;

	//Private Variables
	private Transform _transform; 
	private Vector2 _currentPos; 

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> (); 
		_currentPos = _transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		
		_currentPos = _transform.position;

		float userInput = Input.GetAxis ("Vertical");

		//Targetting specific key - if (Input.GetKey (KeyCode.UpArrow)) 
		if(userInput>0)
		{
			//add bigger range to y position (set direction up) and set speed to y 
			_currentPos += new Vector2(0, speed);
		}

		//if (Input.GetKey (KeyCode.DownArrow)) 
		if(userInput<0)
		{
			//subtract from range of y position (set direction down) and set speed to y
			_currentPos -= new Vector2(0, speed);
		}

		CheckBounds ();
		_transform.position = _currentPos;
	}

	//Check Background image boundaries (Defined in Unity -> 4.2y, -4.2Y)
	private void CheckBounds(){

		//If position bigger than 4.2, set it to 4.2
		if (_currentPos.y > upY) {
			_currentPos.y = upY;
		}

		//If position is smaller than -4.2, set it to -4.2
		if (_currentPos.y < downY) {
			_currentPos.y = downY;
		}

	}
}