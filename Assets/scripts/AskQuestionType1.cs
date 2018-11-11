using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AskQuestionType1 : MonoBehaviour
{
    private AskQuestion askQuestionScript;

    public TextMeshProUGUI QuestionSigne;

    public GameObject Type1;
    public GameObject Type2;
    public GameObject Type3;
    public GameObject Type4;
    public GameObject Question;

    public Canvas QuestionCanvas;
    public TextMeshProUGUI Chiffre1;
    public TextMeshProUGUI Chiffre2;

    public int chiffre1;
    private int symbole;
    public string SymboleString;
    public int chiffre2;

    public int GoodAnswer;

    private void Update()
    {

    }

    // Use this for initialization
    void Start()
    {
        askQuestionScript = gameObject.GetComponent<AskQuestion>();
        askQuestionScript.DisableMessageText();
        QuestionCanvas.enabled = false;

    }

    public void Ask_Question()
    {
        askQuestionScript.DisableMessageText();
        QuestionSigne.text = "?";
        CreateGoodAnswer();
        QuestionCanvas.enabled = true; 
        QuestionCanvas.enabled = true;
        Type2.SetActive(false);
        Type3.SetActive(false);
        Type1.SetActive(true);
        Type4.SetActive(false);
        Question.SetActive(true);
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
        //ConvertSymboleToString();
        //ChooseGoodAnswer();
    }

    //***

    public void CreateChiffres()
    {
        chiffre1 = Random.Range(1, 61);
        chiffre2 = Random.Range(1, 61);
        Chiffre1.text = chiffre1.ToString();
        Chiffre2.text = chiffre2.ToString();
    }

    //private void ConvertSymboleToString()
    //{
       // if (symbole == 1) { SymboleString = "<"; }
       // if (symbole == 2) { SymboleString = "="; }
       // if (symbole == 3) { SymboleString = ">"; }
    //}

    //***

    //private void ChooseGoodAnswer()
    //{
    //    GoodAnswer = Random.Range(1, 4);
    //}

    public void Button1()
    {
        if (symbole == 1) { Debug.LogWarning("Bonne Réponse"); askQuestionScript.isGoodAnswer(); }
        else { Debug.LogWarning("Mauvaise Réponse"); askQuestionScript.isBadAnswer(); }
    }
    public void Button2()
    {
        if (symbole == 2) { Debug.LogWarning("Bonne Réponse"); askQuestionScript.isGoodAnswer(); }
        else { Debug.LogWarning("Mauvaise Réponse"); askQuestionScript.isBadAnswer(); }
    }
    public void Button3()
    {
        if (symbole == 3) { Debug.LogWarning("Bonne Réponse"); askQuestionScript.isGoodAnswer(); }
        else { Debug.LogWarning("Mauvaise Réponse"); askQuestionScript.isBadAnswer(); }
    }



}
