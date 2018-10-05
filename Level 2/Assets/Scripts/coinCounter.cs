using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinCounter : MonoBehaviour {
	
	public static int coins = 0;
	public TextMeshProUGUI Counter;

	public GameObject levelBlocker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Counter.text = coins + "/6";

		if (coins == 6) {
			Destroy(levelBlocker);
		}
	}
}
