using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ManageGame : MonoBehaviour {

    public GameObject Player;
    public Restart script;
    public bool mobile;
    public TextMeshProUGUI scoreTexte;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName == "Menu")
        {
            scoreTexte.enabled = false;
        }else {
            scoreTexte.enabled = true;
        }
    }

    public void ResetPlayerPrefs ()
    {
        PlayerPrefs.DeleteAll();
    }

    public void EndGame ()
    {
        Debug.LogWarning("Le joueur est mort"); 
        Time.timeScale = 0f;
        script.RestartGame();
    }
}
