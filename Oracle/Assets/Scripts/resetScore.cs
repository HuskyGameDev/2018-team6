using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScore : MonoBehaviour {
	public void resetTotalScore() {
		PlayerPrefs.SetInt("Score", 0);
		//hardcoded reset for now
		PlayerPrefs.SetInt("Melee", 4);
	}
	
}
