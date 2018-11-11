using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AskQuestionType3 : MonoBehaviour {

    public GameObject Type1;
    public GameObject Type2;
    public GameObject Type3;
    public GameObject Type4;

    public GameObject Question;

    public int GoodAnswer;
    public int Answer;
    public bool CanAnswer;
    private int number;

    public Canvas QuestionCanvas;
    public TextMeshProUGUI Input;

    private AskQuestion askQuestion;

    public AudioManager audioManager;

    public float MaxCooldownValue;
    public float Cooldown;
    public bool isCooldown;

	// Use this for initialization
	void Start () {
        askQuestion = gameObject.GetComponent<AskQuestion>();
        Cooldown = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (isCooldown == true)
        {
            Cooldown -= Time.fixedDeltaTime;
            if (Cooldown <= 0)
            {
                isCooldown = false;
                Cooldown = MaxCooldownValue;
                if (Answer == GoodAnswer)
                {
                    askQuestion.isGoodAnswer();
                }
                else
                {
                    askQuestion.isBadAnswer();
                }
            }
        }
    }

    public void Ask_Question ()
    {
        QuestionCanvas.enabled = true;
        Input.text = 0.ToString();
        Answer = 0;

        Answer = 0;
        CanAnswer = true;

        GenerateGoodAnswer();
        PlaySound(GoodAnswer);



        Type2.SetActive(false);
        Type3.SetActive(true);
        Type1.SetActive(false);
        Type4.SetActive(false);
        Question.SetActive(false);
    }

    private void GenerateGoodAnswer ()
    {
        GoodAnswer = Random.Range(10, 61);
    }

    private void PlaySound (int SoundNumber)
    {
        audioManager.Play(SoundNumber.ToString());
        Debug.Log("Son joué");
    }

    private void SetAnswer ()
    {
        Answer = (Answer * 10) + number;
        if (Answer >= 10) { CanAnswer = false; VerifyAnswer(); }
        Input.text = Answer.ToString();
    }

    private void VerifyAnswer ()
    {
        isCooldown = true;
        Cooldown = MaxCooldownValue;
    }

    public void Button1 ()
    {
        if(CanAnswer == true)
        {
            number = 1;
            SetAnswer();
        }
    }
    public void Button2()
    {
        if (CanAnswer == true)
        {
            number = 2;
            SetAnswer();
        }
    }
    public void Button3()
    {
        if (CanAnswer == true)
        {
            number = 3;
            SetAnswer();
        }
    }
    public void Button4()
    {
        if (CanAnswer == true)
        {
            number = 4;
            SetAnswer();
        }
    }
    public void Button5()
    {
        if (CanAnswer == true)
        {
            number = 5;
            SetAnswer();
        }
    }
    public void Button6()
    {
        if (CanAnswer == true)
        {
            number = 6;
            SetAnswer();
        }
    }
    public void Button7()
    {
        if (CanAnswer == true)
        {
            number = 7;
            SetAnswer();
        }
    }
    public void Button8()
    {
        if (CanAnswer == true)
        {
            number = 8;
            SetAnswer();
        }
    }
    public void Button9()
    {
        if (CanAnswer == true)
        {
            number = 9;
            SetAnswer();
        }
    }
    public void Button0()
    {
        if (CanAnswer == true)
        {
            number = 0;
            SetAnswer();
        }
    }
}
