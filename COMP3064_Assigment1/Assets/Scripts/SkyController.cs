using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour {
	//Public Variables
	[SerializeField] //Unity annotation (change field value in Unity)
	private float speed = 0.2f; 
	[SerializeField]
	private float startX; 
	[SerializeField]
	private float endX;

	//Private Variables
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

	//Set current position to starting point
	private void Reset(){
		_currentPos = new Vector2 (startX, 0);
	}
}
