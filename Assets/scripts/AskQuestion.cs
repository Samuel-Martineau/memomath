using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AskQuestion : MonoBehaviour
{

    public Canvas QuestionCanvas;
    public TextMeshProUGUI NbDeQuestion;
    public TextMeshProUGUI Chiffre1;
    public TextMeshProUGUI Chiffre2;
    public TextMeshProUGUI TexteBoutton1;
    public TextMeshProUGUI TexteBoutton2;
    public TextMeshProUGUI TexteBoutton3;
    public TextMeshProUGUI TexteBoutton4;

    public int chiffre1;
    private int symbole;
    public string SymboleString;
    public int chiffre2;



    // Use this for initialization
    void Start()
    {
        QuestionCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Ask_Question()
    {
        CreateGoodAnswer();
        QuestionCanvas.enabled = true;
    }

    public void CreateGoodAnswer ()
    {
        CreateChiffres();
        // < : 1  
        // = : 2  
        // > : 3
        if (chiffre1 < chiffre2) { SymboleString = "<"; symbole = 1; }
        if (chiffre1 == chiffre2) { SymboleString = "="; symbole = 2; }
        if (chiffre1 > chiffre2) { SymboleString = ">"; symbole = 3; }
        ConvertSymboleToString();
    }

    public void CreateChiffres ()
    {
        chiffre1 = Random.Range(1, 61);
        chiffre2 = Random.Range(1, 61);
        Chiffre1.text = chiffre1.ToString();
        Chiffre2.text = chiffre2.ToString();
    }

    private void ConvertSymboleToString ()
    {
        if (symbole == 1) { SymboleString = "<"; }
        if (symbole == 2) { SymboleString = "="; }
        if (symbole == 3) { SymboleString = ">"; }
    }


}
