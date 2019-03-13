

/**
 * File Source: explosion.cs 
 * Author: Amanda Braz
 * Last Modified by: Amanda Braz
 * Date Last Modified: 10/20/2017
 * 
 * 
 * Program Description: 
 * Method that destroy the game object (explosion animation)
 *after animation is trigger and played once
 *
 * 
 *  
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {


	public void DestroyMe(){
		Destroy (gameObject); 
	}

}
