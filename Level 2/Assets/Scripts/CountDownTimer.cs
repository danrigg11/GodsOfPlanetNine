using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour {
    
    public TextMeshProUGUI CountDownText;
    public float timeleft = 5f;
    public bool CountDownFinished = false;
    
    public GameObject showObject;

	// Use this for initialization
	void Start () {
		showObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (CountDownFinished)
		return;
        
		timeleft -= Time.deltaTime;
        CountDownText.text = timeleft.ToString("0");
        
        if(timeleft < 0)
        {
            StartLevel();
        }
	}
    
    public void StartLevel(){
        showObject.SetActive(false);
        GameObject.Find ("Score").SendMessage ("clock");
        CountDownFinished = true;
        timeleft = 5f;
    }
    
    public void StartTimerAgain(){
        CountDownFinished = false;
        showObject.SetActive(true);
    }
}
