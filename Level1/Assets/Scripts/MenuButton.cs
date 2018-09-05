using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

	public GameObject menuSection;

	// Use this for initialization
	void Start () {
		menuSection.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Show Menu options
	public void showMenu()
	{
		menuSection.SetActive(true);
		Time.timeScale = 0;
	}
	//Back to menu screen
	public void menuPage()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	//Restart level
	public void onRestart(){
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	//Resume level
	public void onResume(){
		menuSection.SetActive(false);
		Time.timeScale = 1;
	}
}
