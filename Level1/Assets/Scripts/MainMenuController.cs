using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public Text highscore;

	// Use this for initialization
	void Start () {
		highscore.text = PlayerPrefs.GetFloat ("BestTimeMin", 0) + ":" + PlayerPrefs.GetFloat ("BestTimeSec", 0).ToString("f2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Application.LoadLevel(2);
	}
}
