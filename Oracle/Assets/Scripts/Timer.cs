using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class Timer : MonoBehaviour {
	public Text TimerText;
	public Text ScoreText;
	float timer = 0;
	int i = 0;
	float score = 0;
	// Use this for initialization
	void Start () {
		//timer will alwwawys start at 0
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//update time by seconds
		if ( i == 0) {
		if ( timer > 3 ) {
			Score();
			 Time.timeScale = 0;
		}
	
		timer += Time.deltaTime;
		//display
		TimerText.text = ("Time Spent on Level: " + (int)timer + " Seconds");
		}
	}

	//score based on time
	void Score() {
		if ( i == 0) {
		 score = ((5 * 60) - timer) * 10;
		 ScoreText.text = ("Total score: " + (int) score + " Points");
		 Time.timeScale = 0;
		 i++;
		}

	}



}
