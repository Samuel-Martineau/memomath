using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ManageGame : MonoBehaviour {

    public GameObject Player;
    public GameObject joystick;
    public Restart script;
    public bool mobile;
    public TextMeshProUGUI scoreTexte;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.LinuxPlayer)
        {
            mobile = false;
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android)
        {
            mobile = true;
        }
        if (mobile)
        {
            joystick.SetActive(true);
        }
    }

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
