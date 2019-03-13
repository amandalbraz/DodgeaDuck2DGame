

/**
 * File Source: GameController.cs 
 * Author: Amanda Braz
 * Last Modified by: Amanda Braz
 * Date Last Modified: 10/20/2017
 * 
 * 
 * Program Description: 
 * Get and Set for Life and Score
 * Initialize Life and Score + inactivate game over labels
 * Create Game over method to display labels and final Life/Score
 * Reload Scene one button is clicked
 * 
 * 
 *  
*/





using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//Public Variables - Correspond Text Labes (Canvas) Added from Unity 
	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button restartButton;

	//Private Variables for Life and Score
	private int _score = 0;
	private int _life = 5;

	public int Score{
		get {return _score;}
		set{ _score = value;
			scoreLabel.text = "SCORE: " + _score;
		}
	}

	public int Life{
		get {return _life;}
		set{ 
			
		_life = value;
		if(_life <= 0) { 
				//game over
				gameOver();
		}else{
				//Update UI
				lifeLabel.text = "LIFE: " + _life;
			}
		}
	}//end of life

	private void initialize(){
	
		Score = 0; 
		Life = 5; 

		//Makes objects disapear and stop interativity 
		gameOverLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (false);
		restartButton.gameObject.SetActive (false);

		//Makes score and life constantly active
		scoreLabel.gameObject.SetActive (true);
		lifeLabel.gameObject.SetActive (true);
	
	}

	private void gameOver(){
	
		//Makes objects active 
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);
		restartButton.gameObject.SetActive (true);

		//Make score and life disapear (Final output on UpdateUI() )
		scoreLabel.gameObject.SetActive (false);
		lifeLabel.gameObject.SetActive (false);
	
	}

	// Use this for initialization
	void Start () {
		initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RestartBtnClick(){
		//Get scene name and reload - connection created in Unity on CLick()
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
