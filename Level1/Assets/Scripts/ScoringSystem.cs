using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour {
	// Scoring System
	public float numberMin;
	public float numberSec;
	public Text score;
	public Text highscore;

	private float startTime;
	private bool finnished = false;

	void Awake ()
	{
		startTime = Time.time;
		numberMin = 0;
		numberSec = 0;
		highscore.text = "Best: " + PlayerPrefs.GetFloat ("BestTimeMin", 0) + ":" + PlayerPrefs.GetFloat ("BestTimeSec", 0).ToString("f2");
	}

	void Update ()
	{
		if (finnished)
		return;

		float t = Time.time - startTime;

		float minutes = ((int)t / 60);
		float seconds = (t % 60);

		score.text = "Time: " + minutes + ":" + seconds.ToString("f2");
		numberMin = minutes;
		numberSec = seconds;

	}

	public void Finnish()
	{
		finnished = true;
		if (numberMin < PlayerPrefs.GetFloat ("BestTimeMin", 0) && numberSec < PlayerPrefs.GetFloat ("BestTimeSec", 0) || PlayerPrefs.GetFloat ("BestTimeMin", 0) < 1 && PlayerPrefs.GetFloat ("BestTimeSec", 0) < 1){
			PlayerPrefs.SetFloat ("BestTimeMin", numberMin);
			PlayerPrefs.SetFloat ("BestTimeSec", numberSec);
			numberSec = Mathf.Round(numberSec * 10f) / 10f;
			highscore.text = numberMin + ":" + numberSec;
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
