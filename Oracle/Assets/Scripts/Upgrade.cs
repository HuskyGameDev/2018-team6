using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Upgrade : MonoBehaviour {
	public Text AvailableScore;
	int score;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("Score");
		AvailableScore.text = ("Available Points: " + score);
	}
	void Update() {
		score = PlayerPrefs.GetInt("Score");
	
		AvailableScore.text = ("Available Points: " + score);
	}

public void hi (int points) {
		PlayerPrefs.SetInt("Score", score - points);
		//PlayerPrefs.SetInt(tower, damage);
		AvailableScore.text = ("Available Points: " + score);
		//AvailableScore.text = ("HI");
}
	public void purchase(String tower, int damage, int points) {
		PlayerPrefs.SetInt("Score", score - points);
		PlayerPrefs.SetInt(tower, damage);
		AvailableScore.text = ("Available Points: " + score);
	}
}
