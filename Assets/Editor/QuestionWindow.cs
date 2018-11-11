using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class QuestionWindow : EditorWindow {
    

    [MenuItem("Window/Question Window")]
    public static void ShowWindow ()
    {
        GetWindow<QuestionWindow>("Questions");
    }

    private void OnGUI()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        GUILayout.Label("Choisissez le type de question que vous voulez poser.", EditorStyles.boldLabel);
        GUILayout.Label(" ");

        GUILayout.BeginHorizontal();
        if(GUILayout.Button("Plus petit / Plus grand / Égal"))
        {
            if(currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().Ask_Question(1);
                Debug.Log("Poser une question de type 1");
            }
        }
        if (GUILayout.Button("Aditions"))
        {
            if (currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().Ask_Question(2);
                Debug.Log("Poser une question de type 2");
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Identfication de chiffres"))
        {
            if (currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().Ask_Question(3);
                Debug.Log("Poser une question de type 3");
            }
        }
        if (GUILayout.Button("Termes manquants"))
        {
            if (currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().Ask_Question(4);
                Debug.Log("Poser une question de type 4");
            }
        }
        GUILayout.EndHorizontal();
        if (GUILayout.Button("Question aléatoire"))
        {
            if (currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().Ask_Question(5);
                Debug.Log("Poser une question de type 5");
            }
        }
        GUILayout.Label(" ", EditorStyles.boldLabel);
        if (GUILayout.Button("Avoir une bonne réponse"))
        {
            if (currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().isGoodAnswer();
            }
        }
        if (GUILayout.Button("Avoir une mauvaise réponse"))
        {
            if (currentScene != "Menu")
            {
                GameObject.Find("Question").GetComponent<AskQuestion>().isBadAnswer();
            }
        }
        GUILayout.Label(" ", EditorStyles.boldLabel);
        if (GUILayout.Button("Stoper le temps"))
        {
            Time.timeScale = 0;
        }
        if (GUILayout.Button("Remettre le temps à la vitesse normale"))
        {
            if (currentScene != "Menu")
            {
                Time.timeScale = 1;
            }
        }
        GUILayout.Label(" ", EditorStyles.boldLabel);
        if (GUILayout.Button("Supprimer toutes les PlayersPrefs de l'éditeur"))
        {
            PlayerPrefs.DeleteAll();
        }
    }

}
