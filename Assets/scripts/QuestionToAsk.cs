using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionToAsk : MonoBehaviour {

    public int NumberQuestionToAsk;

    private GameObject Question;
    private AskQuestion askQuestion;
    Scene currentScene;
    int SceneIndex;


    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();
        SceneIndex = currentScene.buildIndex;

        if (SceneIndex != 0)
        {
            Question = GameObject.Find("Question");
            askQuestion = Question.GetComponent<AskQuestion>();
        }

	}
}
