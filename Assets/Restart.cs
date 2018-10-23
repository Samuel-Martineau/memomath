using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    public int SceneIndex;

    public Canvas restartMenu;

    public LevelLoader script;

	// Use this for initialization
	void Start () {
        restartMenu.enabled = false;
	}
	
	public void RestartGame ()
    {
        restartMenu.enabled = true;
    }

    public void BouttonRejouer ()
    {
        Time.timeScale = 1;
        script.FadeToLevel(SceneIndex);
        Debug.Log("test");
    }
    public void BouttonMenu()
    {
        Time.timeScale = 1;
        script.FadeToLevel(0);
        Debug.Log("test");
    }
}
