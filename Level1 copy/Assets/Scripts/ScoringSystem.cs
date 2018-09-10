﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoringSystem : MonoBehaviour {
	// Scoring System
	public float numberMin;
	public float numberSec;
	public TextMeshProUGUI highscore;
	public TextMeshProUGUI score;

	private float startTime;
	private bool finnished = false;
    public bool startClock = false;

	public GameObject tooSlowSection;
	public GameObject newHighScoreSection;
    public GameObject levelCage;

	void Awake ()
	{
		tooSlowSection.SetActive(false);
		newHighScoreSection.SetActive(false);
		startTime = Time.time;
		numberMin = 0;
		numberSec = 0;
		highscore.text = PlayerPrefs.GetFloat ("BestTimeMin", 0) + ":" + PlayerPrefs.GetFloat ("BestTimeSec", 0).ToString("f2");
	}

	void Update ()
	{
		if (finnished)
		return;
        
        if (startClock == true){
            Destroy(levelCage);
            float t = Time.time - startTime - 5.0f;

		float minutes = ((int)t / 60);
		float seconds = (t % 60);

		score.text = minutes + ":" + seconds.ToString("f2");
		numberMin = minutes;
		numberSec = seconds;

		if (Input.GetKey(KeyCode.R))
		{
			float numberrestart = 00;
			PlayerPrefs.SetFloat ("BestTimeMin", numberrestart);
			PlayerPrefs.SetFloat ("BestTimeSec", numberrestart);
			highscore.text = PlayerPrefs.GetFloat ("BestTimeMin", 0) + ":" + PlayerPrefs.GetFloat ("BestTimeSec", 0).ToString("f2");
		}
        }

	}

	public void Finnish()
	{
		finnished = true;
		if (numberMin <= PlayerPrefs.GetFloat ("BestTimeMin", 0) && numberSec <= PlayerPrefs.GetFloat ("BestTimeSec", 0) || PlayerPrefs.GetFloat ("BestTimeMin", 0) < 1 && PlayerPrefs.GetFloat ("BestTimeSec", 0) < 1){
			PlayerPrefs.SetFloat ("BestTimeMin", numberMin);
			PlayerPrefs.SetFloat ("BestTimeSec", numberSec);
			numberSec = Mathf.Round(numberSec * 10f) / 10f;
			highscore.text = numberMin + ":" + numberSec.ToString("f2");
			newHighScoreSection.SetActive(true);
			Time.timeScale = 0;
		} else {
			tooSlowSection.SetActive(true);
			Time.timeScale = 0;
		}

	}
    public void clock(){
        startClock = true;
    }

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
