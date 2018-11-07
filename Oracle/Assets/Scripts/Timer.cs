using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class Timer : MonoBehaviour {
	public Text TimerText;
	public Text ScoreText;
	public Text RoundScore;
	public GameObject Game;
	public GameObject complete;
	public GameObject  pauseButton;
	//set to true to test score and load the next level, otherwise will run scene as normal
	public bool testing;

	float timer = 0;
	int i = 0;
	float score = 0;
	// Use this for initialization
	void Start () {
		//timer will always start at 0
		timer = 0;
		Game.SetActive(true);
		complete.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
		//update time by seconds
		if ( i == 0) {
		if ( timer > 3 && testing) {
			Score();
			 Time.timeScale = 0;
			 //disable game/game UI and enable level complete and score screen
			 Game.SetActive(false);
			 complete.SetActive(true);
			 pauseButton.SetActive(false);
			 

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
		 int total = (int)score + PlayerPrefs.GetInt("Score");
		 PlayerPrefs.SetInt("Score", (int) total);
		 PlayerPrefs.SetInt("Round Score", (int)score);
		 ScoreText.text = ("Total score: " + (int) total + " Points");
		 RoundScore.text = ("Round Score: " + (int)score + " Points");
		 Time.timeScale = 0;
		 Game.SetActive(false);
		 i++;
		}

	}



}
