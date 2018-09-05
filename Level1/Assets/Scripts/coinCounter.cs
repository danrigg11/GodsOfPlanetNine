using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinCounter : MonoBehaviour {
	
	public int coins;
	public TextMeshProUGUI Counter;

	// Use this for initialization
	void Start () {
		coins = 0;
		Counter.text = coins + "/6";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
