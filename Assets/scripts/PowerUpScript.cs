using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpScript : MonoBehaviour {

    GameObject Question;
    AskQuestion script;

    GameObject GameManager;
    QuestionToAsk scriptGameManager;

    private void Start()
    {
        Question = GameObject.Find("Question");
        script = Question.GetComponent<AskQuestion>();
        GameManager = GameObject.Find("GameManager");
        scriptGameManager = GameManager.GetComponent<QuestionToAsk>();
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
        script.Ask_Question(scriptGameManager.NumberQuestionToAsk);
    }

}
