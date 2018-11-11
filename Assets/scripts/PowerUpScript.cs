using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpScript : MonoBehaviour {

    GameObject Question;
    AskQuestion script;

    GameObject GameData;
    GameData DataScript;

    private void Start()
    {
        Question = GameObject.Find("Question");
        script = Question.GetComponent<AskQuestion>();
        GameData = GameObject.Find("Game Data");
        DataScript = GameData.GetComponent<GameData>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if (script.isAnsweringQuestion == false) { Pickup(); }
        }
    }

    void Pickup()
    {
        script.isAnsweringQuestion = true;
        Destroy(gameObject);
        Debug.LogWarning("Une question doit être posée");
        script.Ask_Question(DataScript.NumberQuestionToAsk);
    }

}
