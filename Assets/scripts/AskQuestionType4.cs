using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AskQuestionType4 : MonoBehaviour {

    public GameObject[] Others;

    public Canvas QuestionCanvas;
    public TextMeshProUGUI Question;
    public GameObject BQuestion;

    public TextMeshProUGUI[] TextesBouttons;
    public int[] Chiffres;
    int Total;
    int GoodAnswer;

    private AskQuestion askQuestionScript;

	// Use this for initialization
	void Start () {
        askQuestionScript = gameObject.GetComponent<AskQuestion>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Ask_Question ()
    {
        QuestionCanvas.enabled = true;
        Question.enabled = true;
        BQuestion.SetActive(false);
        Others[0].SetActive(true);
        Others[1].SetActive(false);
        Others[2].SetActive(false);
        Others[3].SetActive(false);
        GenerateNumbers();
        SetText();
    }

    public void GenerateNumbers ()
    {
        Chiffres[0] = Random.Range(0, 16);
        Chiffres[1] = Random.Range(0, 16);
        Total = Chiffres[0] + Chiffres[1];
        if (Total > 15) { GenerateNumbers(); }
        int total2 = Total + 1;
        Chiffres[2] = Random.Range(0, total2);
        Chiffres[3] = Total - Chiffres[2];

    }

    public void SetText ()
    {
        Question.text = Chiffres[0] + " + " + Chiffres[1] + " = " + Chiffres[2] + " + ?";
        GenerateRandomAnswers();
        GoodAnswer = Random.Range(0, 4);
        TextesBouttons[GoodAnswer].text = Chiffres[3].ToString();

    }

    private void GenerateRandomAnswers ()
    {
        int Number1 = Random.Range(0, 15);
        int Number2 = Random.Range(0, 15);
        int Number3 = Random.Range(0, 15);
        int Number4 = Random.Range(0, 15);

        while (Number1 == Number2 || Number1 == Number3 || Number1 == Number4 || Number2 == Number3 || Number2 == Number4 || Number3 == Number4 || Chiffres[3] == Number1 || Chiffres[3] == Number2 || Chiffres[3] == Number3 || Chiffres[3] == Number4)
        {
             Number1 = Random.Range(0, 15);
             Number2 = Random.Range(0, 15);
             Number3 = Random.Range(0, 15);
             Number4 = Random.Range(0, 15);
        }

        TextesBouttons[0].text = Number1.ToString();
        TextesBouttons[1].text = Number2.ToString();
        TextesBouttons[2].text = Number3.ToString();
        TextesBouttons[3].text = Number4.ToString();
    }

    public void Button1 ()
    {
        if(GoodAnswer == 0)
        {
            askQuestionScript.isGoodAnswer();
        } 
        else 
        {
            askQuestionScript.isBadAnswer();
        }
    }
    public void Button2()
    {
        if (GoodAnswer == 1)
        {
            askQuestionScript.isGoodAnswer();
        }
        else
        {
            askQuestionScript.isBadAnswer();
        }
    }
    public void Button3()
    {
        if (GoodAnswer == 2)
        {
            askQuestionScript.isGoodAnswer();
        }
        else
        {
            askQuestionScript.isBadAnswer();
        }
    }
    public void Button4()
    {
        if (GoodAnswer == 3){
            askQuestionScript.isGoodAnswer();
        }
        else
        {
            askQuestionScript.isBadAnswer();
        }
    }

    private void SayHelloWorld ()
    {
        Debug.Log("Hello World");
    }
}
