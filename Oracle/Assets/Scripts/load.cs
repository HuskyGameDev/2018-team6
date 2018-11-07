using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class load : MonoBehaviour {
    public void LoadScene(string sceneName)
    {
        //load scene
        SceneManager.LoadScene(sceneName);
    }
}