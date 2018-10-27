using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Restart : MonoBehaviour {

    public int SceneIndex;

    public string PlayerPref;

    public Canvas restartMenu;

    public TextMeshProUGUI TextScore;
    public TextMeshProUGUI TextBestScore;

    public LevelLoader script;

    public GameObject QuestionMenu;
    AskQuestion ScoreScript;
    public int Score;

	// Use this for initialization
	void Start () {
        restartMenu.enabled = false;
        ScoreScript = QuestionMenu.GetComponent<AskQuestion>();
	}
	
	public void RestartGame ()
    {
        QuestionMenu.SetActive(false);
        Score = ScoreScript.Score;
        restartMenu.enabled = true;
        TextScore.text = "Score: " + Score;
        TextBestScore.text = "Meilleur score: " + PlayerPrefs.GetInt(PlayerPref);
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
