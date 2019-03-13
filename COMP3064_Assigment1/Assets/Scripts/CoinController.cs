

/**
 * File Source: CoinController.cs 
 * Author: Amanda Braz
 * Last Modified by: Amanda Braz
 * Date Last Modified: 10/20/2017
 * 
 * 
 * Program Description: 
 * Get and Transform Coin position
 * Reset Coin 
 * Set random range to display coin in new position once reset
 * 
 *  
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	//Public Variables - Accessible in Unity
	[SerializeField]
	private float speed = 0.2f;
	[SerializeField]
	private float startY = 4.5f;
	[SerializeField]
	private float endY = -4.5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;


	private Transform _transform; 
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> (); 
		_currentPos = _transform.position;
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position; 
		_currentPos -= new Vector2 (speed, 0);

		//Check if we need to reset
		if (_currentPos.x < endX){
			Reset ();
		}
		//Apply changes
		_transform.position = _currentPos;
	}

	//Once coin reset, add different range to change position
	private void Reset(){
		float y = Random.Range (startY, endY); 
		float dx = Random.Range (-7, 7); 
		_currentPos = new Vector2 (startX + dx, y); 
	
	}

}
