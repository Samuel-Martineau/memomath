using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AskQuestion : MonoBehaviour {

    public bool isAnsweringQuestion;

    public string PlayerPref;

    AskQuestionType1 askQuestionType1;
    AskQuestionType2 askQuestionType2;

    public TextMeshProUGUI TexteScore;
    public int Score;

    public float timer;

    private int NbQuestion;
    public TextMeshProUGUI NbDeQuestion;

    public Canvas QuestionCanvas;

    public TextMeshProUGUI TextBravo;
    public TextMeshProUGUI TextOups;

    private bool cooldown;

    public GameObject CameraJeu;
    CameraMouvement VitesseScript;

    // Use this for initialization
    void Start () {
        isAnsweringQuestion = false;
        askQuestionType1 = gameObject.GetComponent<AskQuestionType1>();
        askQuestionType2 = gameObject.GetComponent<AskQuestionType2>();
        TexteScore.text = "Score: 0";
        DisableMessageText();
        VitesseScript = CameraJeu.GetComponent<CameraMouvement>();
        QuestionCanvas.enabled = false;
        NbQuestion = 1;
    }

    private void Update()
    {
        if (cooldown == true)
        {
            timer -= Time.fixedDeltaTime;
            if (timer <= 0)
            {
                DisableMessageText();
                timer = 1;
            }
        }
    }

    public void Ask_Question (int QuestionNumber)
    {
        if (QuestionNumber == 1) { askQuestionType1.Ask_Question(); }
        if (QuestionNumber == 2) { askQuestionType2.Ask_Question(); }
        NbDeQuestion.text = "Question #" + NbQuestion;
        NbQuestion++;
        

    }
    public void isGoodAnswer()
    {
        Score++;
        if (Score > PlayerPrefs.GetInt(PlayerPref)) { PlayerPrefs.SetInt(PlayerPref, Score); }
        TexteScore.text = "Score: " + Score;
        QuestionCanvas.enabled = false;
        VitesseScript.Vitesse++;


        TextBravo.enabled = true;
        TextOups.enabled = false;
        cooldown = true;
        isAnsweringQuestion = false;

    }
    public void isBadAnswer()
    {
        QuestionCanvas.enabled = false;

        TextOups.enabled = true;
        TextBravo.enabled = false;
        cooldown = true;
        isAnsweringQuestion = false;
    }

    public void DisableMessageText()
    {
        TextBravo.enabled = false;
        TextOups.enabled = false;
        cooldown = false;
    }
}
