using UnityEngine;
using System.Collections;

public class GuessIt : MonoBehaviour {
	/**
	 * 
	 * Variable Declaration
	 * 
	 */
	int max;
	int min;
	int guess;
	void Start () {
		uGame ();
	}

	void uGame(){
	
		guess = 500;
		min = 0;
		max = 1000;
		print ("–––––––––––––––––––––––––––––––––––––––––––");
		print ("Welcome to GuessIt!");
		print ("Pick a number, but don't tell me the number!");
		
	
		
		
		print ("Settings > ");
		print ("MAX NUMBER > " + max + "");
		print ("MIN NUMBER > " + min + "");
		
		print ("KEY BINDS > ");
		print ("UP = HIGHER ");
		print ("DOWN = LOWER ");
		print ("SPACE = CORRECT");
		
		print ("Is the number higher or lower than " + guess);
		max = max + 1;

	}

	void nextGuess(){
		guess = (max + min) / 2;
		print ("KEY BINDS > ");
		print ("UP = HIGHER ");
		print ("DOWN = LOWER ");
		print ("SPACE = CORRECT");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// debug: print ("Up arrow!");
			min = guess;
			nextGuess();
			print ("Is the number higher or lower than " + guess +"?");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print (" Down Arrow!");
			max = guess;

			nextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print (" I won!");
			uGame();
		}




   


	}
}
