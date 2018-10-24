using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AskQuestion : MonoBehaviour
{
    public GameObject CameraJeu;
    CameraMouvement VitesseScript;


    public Canvas QuestionCanvas;
    public TextMeshProUGUI NbDeQuestion;
    public TextMeshProUGUI Chiffre1;
    public TextMeshProUGUI Chiffre2;

    public TextMeshProUGUI TexteScore;

    private int[] BadAnswers;

    public int chiffre1;
    private int symbole;
    public string SymboleString;
    public int chiffre2;

    public int GoodAnswer;

    public int Score;



    // Use this for initialization
    void Start()
    {
        VitesseScript = CameraJeu.GetComponent<CameraMouvement>();
        QuestionCanvas.enabled = false;
        TexteScore.text = "Score: 0";
    }

    public void Ask_Question()
    {
        NbDeQuestion.text = "Question #" + (Score + 1);
        CreateGoodAnswer();
        QuestionCanvas.enabled = true; 
        QuestionCanvas.enabled = true;
    }

    public void CreateGoodAnswer()
    {
        CreateChiffres();
        // < : 1  
        // = : 2  
        // > : 3
        if (chiffre1 < chiffre2) { SymboleString = "<"; symbole = 1; }
        if (chiffre1 == chiffre2) { SymboleString = "="; symbole = 2; }
        if (chiffre1 > chiffre2) { SymboleString = ">"; symbole = 3; }
        ConvertSymboleToString();
        ChooseGoodAnswer();
    }

    //***

    public void CreateChiffres()
    {
        chiffre1 = Random.Range(1, 61);
        chiffre2 = Random.Range(1, 61);
        Chiffre1.text = chiffre1.ToString();
        Chiffre2.text = chiffre2.ToString();
    }

    private void ConvertSymboleToString()
    {
        if (symbole == 1) { SymboleString = "<"; }
        if (symbole == 2) { SymboleString = "="; }
        if (symbole == 3) { SymboleString = ">"; }
    }

    //***

    private void ChooseGoodAnswer()
    {
        GoodAnswer = Random.Range(1, 4);
    }

    public void Button1()
    {
        if (symbole == 1) { Debug.LogWarning("Bonne Réponse"); isGoodAnswer(); }
        else { Debug.LogWarning("Mauvaise Réponse"); isBadAnswer(); }
    }
    public void Button2()
    {
        if (symbole == 2) { Debug.LogWarning("Bonne Réponse"); isGoodAnswer(); }
        else { Debug.LogWarning("Mauvaise Réponse"); isBadAnswer(); }
    }
    public void Button3()
    {
        if (symbole == 3) { Debug.LogWarning("Bonne Réponse"); isGoodAnswer(); }
        else { Debug.LogWarning("Mauvaise Réponse"); isBadAnswer(); }
    }

    public void isGoodAnswer ()
    {
        Score++;
        TexteScore.text = "Score: " + Score;
        QuestionCanvas.enabled = false;
    }
    public void isBadAnswer()
    {
        QuestionCanvas.enabled = false;
        VitesseScript.Vitesse ++;
    }


}
