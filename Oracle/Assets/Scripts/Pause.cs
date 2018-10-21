 using UnityEngine;
 using System.Collections;
 
 public class Pause : MonoBehaviour {
    GameObject[] pauseObjects;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () {

		//unpause
	
		
			if(Time.timeScale == 0)
			{
				Time.timeScale = 1;
				
			} 
		
	}


	//Reloads the Level
	public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}

	//controls the pausing of the scene
	public void pauseControl(){
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
			
			} else {
				Time.timeScale = 1;
			
			}
	}



	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
 }