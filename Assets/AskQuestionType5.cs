using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskQuestionType5 : MonoBehaviour
{
    public int MaxValue;
    private int maxValue;
    private AskQuestionType1 askQuestionType1;
    private AskQuestionType2 askQuestionType2;
    private AskQuestionType3 askQuestionType3;


    private void Start()
    {
        askQuestionType1 = gameObject.GetComponent<AskQuestionType1>();
        askQuestionType2 = gameObject.GetComponent<AskQuestionType2>();
        askQuestionType3 = gameObject.GetComponent<AskQuestionType3>();
    }

    public void Ask_Question()
    {
        maxValue = MaxValue + 1;
        int question = Random.Range(1, maxValue);
        if (question == 1) { askQuestionType1.Ask_Question(); }
        if (question == 2) { askQuestionType2.Ask_Question(); }
        if (question == 3) { askQuestionType3.Ask_Question(); }
    }

}
