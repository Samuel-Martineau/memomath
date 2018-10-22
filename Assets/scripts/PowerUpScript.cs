using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

    GameObject Question;
    AskQuestion script;

    private void Start()
    {
        Question = GameObject.Find("Question");
        script = Question.GetComponent<AskQuestion>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Destroy(gameObject);
        Debug.LogWarning("Une question doit être posée");
        script.Ask_Question();
    }

}
