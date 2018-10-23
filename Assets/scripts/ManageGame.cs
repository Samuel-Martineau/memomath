using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour {

    public GameObject Player;
    public Restart script;

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
