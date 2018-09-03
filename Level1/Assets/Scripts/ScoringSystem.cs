using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour {
	// Scoring System
	public static int number;
	public Text score;
	public Text highscore;

	private float startTime;
	private bool finnished = false;

	void Awake ()
	{
		startTime = Time.time;
		number = 0;
		highscore.text = "Best: " + PlayerPrefs.GetInt ("BestTime", 0).ToString ();
	}

	void Update ()
	{
		if (finnished)
		return;

		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");

		score.text = "Time: " + minutes + ":" + seconds.ToString ();
		number = minutes + seconds;

	}

	public void Finnish()
	{
		finnished = true;
		if (number > PlayerPrefs.GetInt ("BestTime", 3000)) {
			PlayerPrefs.SetInt ("BestTime", number);
			highscore.text = "BestTime: " + number.ToString ();
			Time.timeScale = 0;
		} else {
			Time.timeScale = 0;
		}

	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
