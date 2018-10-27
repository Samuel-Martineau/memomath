using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AskQuestionType2 : MonoBehaviour
{
    public GameObject Type1;
    public GameObject Type2;

    private AskQuestion askQuestionScript;

    public TextMeshProUGUI QuestionSigne;

    public TextMeshProUGUI Chiffre1;
    public TextMeshProUGUI Chiffre2;

    public int[] answers;

    public int answer1;
    public int answer2;
    public int answer3;
    public int answer4;

    public TextMeshProUGUI button1texte;
    public TextMeshProUGUI button2texte;
    public TextMeshProUGUI button3texte;
    public TextMeshProUGUI button4texte;
    private int button1;
    private int button2;
    private int button3;
    private int button4;

    public int GoodAnswer;

    public Canvas QuestionCanvas;

    public int[] NumberCanBeAsk;

    public int chiffre1;
    public int chiffre2;

    private void Update()
    {
    }

    private void Start()
    {
        askQuestionScript = gameObject.GetComponent<AskQuestion>();
        askQuestionScript.DisableMessageText();
    }

    public void Ask_Question()
    {
        askQuestionScript.DisableMessageText();
        GenerateNb();
        GenerateGoodAnswer();

        GenerateAnswers();
        SetButtonsTexte();
        SetText();

        QuestionCanvas.enabled = true;
        Type2.SetActive(true);
        Type1.SetActive(false);
    }

    private void SetText()
    {
        QuestionSigne.text = " + ";
        Chiffre1.text = chiffre1.ToString();
        Chiffre2.text = chiffre2.ToString();
    }

    private void GenerateNb ()
    {
        chiffre1 = Random.Range(1, 11);
        Chiffre1.text = chiffre1.ToString();
    }


    public void GenerateAnswers()
    {
        GenerateGoodAnswer();
        GenerateAnswer2();
        GenerateAnswer3();
        GenerateAnswer4();

        answers = new int[] {answer1, answer2, answer3, answer4 };
    }
    private void GenerateGoodAnswer()
    {
        int Answer = Random.Range(0, NumberCanBeAsk.Length);
        chiffre2 = NumberCanBeAsk[Answer];
        answer1 = chiffre1 + chiffre2;
    }
    private void GenerateAnswer2()
    {
        int Answer = Random.Range(0, NumberCanBeAsk.Length);
        answer2 = chiffre1 + NumberCanBeAsk[Answer];
        if (answer2 == answer1) { GenerateAnswer2(); }
    }
    private void GenerateAnswer3()
    {
        int Answer = Random.Range(0, NumberCanBeAsk.Length);
        answer3 = chiffre1 + NumberCanBeAsk[Answer];
        if (answer3 == answer1 || answer3 == answer2) { GenerateAnswer3(); }
    }
    private void GenerateAnswer4()
    {
        int Answer = Random.Range(0, NumberCanBeAsk.Length);
        answer4 = chiffre1 + NumberCanBeAsk[Answer];
        if (answer4 == answer1 || answer4 == answer2 || answer4 == answer3) { GenerateAnswer4(); }
    }


    public void SetButtonsTexte ()
    {
        SetButton1Texte();
        SetButton2Texte();
        SetButton3Texte();
        SetButton4Texte();
    }
    private void SetButton1Texte ()
    {
        int answer = Random.Range(0, answers.Length);
        button1texte.text = answers[answer].ToString();
        button1 = answers[answer];
        if (answers[0] == button1) { GoodAnswer = 1; }

    }
    private void SetButton2Texte()
    {
        int answer = Random.Range(0, answers.Length);
        button2texte.text = answers[answer].ToString();
        button2 = answers[answer];
        if (button2 == button1) { SetButton2Texte(); }
        if (answers[0] == button2) { GoodAnswer = 2; }
    }
    private void SetButton3Texte()
    {
        int answer = Random.Range(0, answers.Length);
        button3texte.text = answers[answer].ToString();
        button3 = answers[answer];
        if (button3 == button2 || button3 == button1) { SetButton3Texte(); }
        if (answers[0] == button3) { GoodAnswer = 3; }
    }
    private void SetButton4Texte()
    {
        int answer = Random.Range(0, answers.Length);
        button4texte.text = answers[answer].ToString();
        button4 = answers[answer];
        if (button4 == button3 || button4 == button2 || button4 == button1) { SetButton4Texte(); }
        if (answers[0] == button4) { GoodAnswer = 4; }
    }

    public void isButton1 () 
    {
        if (GoodAnswer == 1) { askQuestionScript.isGoodAnswer(); }
        else { askQuestionScript.isBadAnswer(); }
    }
    public void isButton2()
    {
        if (GoodAnswer == 2) { askQuestionScript.isGoodAnswer(); }
        else { askQuestionScript.isBadAnswer(); }
    }
    public void isButton3()
    {
        if (GoodAnswer == 3) { askQuestionScript.isGoodAnswer(); }
        else { askQuestionScript.isBadAnswer(); }
    }
    public void isButton4()
    {
        if (GoodAnswer == 4) { askQuestionScript.isGoodAnswer(); }
        else { askQuestionScript.isBadAnswer(); }
    }
}
