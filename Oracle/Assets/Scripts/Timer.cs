using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class Timer : MonoBehaviour {
	public Text TimerText;
	float timer = 0;
	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		TimerText.text = ("Time Spent on Level: " + (int)timer + " Seconds");
	}


}
