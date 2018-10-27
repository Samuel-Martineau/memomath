using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateQuestion : MonoBehaviour {

    public GameObject Question;
    public Vector3 pos;
    public Quaternion rotation;

    public GameObject CameraJeu;
    CameraMouvement VitesseScript;

    public float maxTime;
    public float timer;
    private  float maximumTime;

    private void Start()
    {
        VitesseScript = CameraJeu.GetComponent<CameraMouvement>();

        maximumTime = maxTime + 1;
        SetTimer();
    }

    private void FixedUpdate()
    {
        maximumTime = maxTime + 1;

        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {
            GenerateQuestion();
        }
    }

    private void SetTimer ()
    {

        timer = Random.Range(1f, maximumTime);
    }

    public void GenerateQuestion ()
    {
        pos = GameObject.Find("Poseur de question").transform.position;
        Instantiate(Question, pos, rotation, null);
        SetTimer();
    }
}
