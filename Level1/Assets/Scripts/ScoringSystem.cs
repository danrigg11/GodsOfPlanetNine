using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

	public static int number;
	public Text score;
	public Text highscore;

	Text text;

	void Awake ()
	{
		text = GetComponent <Text> ();
		number = 0;
		highscore.text = "High Score: " + PlayerPrefs.GetInt ("HighScore", 0).ToString ();
	}

	void Update ()
	{
		text.text = "Score: " + number;	
		score.text = "Score: " + number.ToString ();

		if (number > PlayerPrefs.GetInt ("HighScore", 0)) 
		{
			PlayerPrefs.SetInt ("HighScore", number);
			highscore.text = number.ToString ();
		}
	}
}
