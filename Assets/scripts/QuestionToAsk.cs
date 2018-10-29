using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionToAsk : MonoBehaviour {

    public int NumberQuestionToAsk;

    private GameObject Question;
    private AskQuestion askQuestion;

	// Use this for initialization
	void Start () {
        Question = GameObject.Find("Question");
        askQuestion = Question.GetComponent<AskQuestion>();
	}
	
	// Update is called once per frame
	void Update () {
        NumberQuestionToAsk = askQuestion.QuestionNbType;
	}
}
