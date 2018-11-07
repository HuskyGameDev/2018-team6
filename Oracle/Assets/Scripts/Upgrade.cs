using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class Upgrade : MonoBehaviour {
	public Text AvailableScore;
	public Text currentDamage;
	int score;
	int damage;
	int points;
	string towerName;



	// Use this for initialization
	void Start () {
		//get current numbers on load
		score = PlayerPrefs.GetInt("Score");
		AvailableScore.text = ("Available Points: " + score);
		damage = PlayerPrefs.GetInt("Melee");
		
	}
	void Update() {
		//set text on update
		AvailableScore.text = ("Available Points: " + score);
		currentDamage.text = ("Current Damage of tower: " + damage);
	
	}

	public void setPoints (int point) {
		//calculate and change points player currently has
		points = point;
		score = score - point;
		if (score > 0) {
			PlayerPrefs.SetInt("Score", score);
		} 

	}



	public void setDamage(int d) {
		//calculate and update damage for tower whose upgrade button was clicked
		towerName =  EventSystem.current.currentSelectedGameObject.name;
		damage = PlayerPrefs.GetInt(name);
		if ( score > 0) {
			//towerName =  EventSystem.current.currentSelectedGameObject.name;
			damage = damage + d;
			PlayerPrefs.SetInt(name, damage);
		} else {
			score = score + points;
		}
		
	}


}
