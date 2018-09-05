using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuController : MonoBehaviour {

	public TextMeshProUGUI highscore;

	// Use this for initialization
	void Start () {
		highscore.text = PlayerPrefs.GetFloat ("BestTimeMin", 0) + ":" + PlayerPrefs.GetFloat ("BestTimeSec", 0).ToString("f2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
