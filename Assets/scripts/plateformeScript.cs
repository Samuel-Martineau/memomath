using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateformeScript : MonoBehaviour {

    public Collider2D plateformes;
    private Joystick joystick;
    private ManageGame GameManger;

    private void Start()
    {
        GameManger = GameObject.Find("GameManager").GetComponent<ManageGame>();
        joystick = GameObject.Find("JoyStick").GetComponentInChildren<Joystick>();
    }

    private void Update()
    {
        float verticalMove = joystick.Vertical;
        if (Input.GetButtonDown("Crouch")) { plateformes.enabled = false; Debug.Log("Player accroupi"); } else if (Input.GetButtonUp("Crouch")) { plateformes.enabled = true; }
        if (GameManger.mobile == true)
        {
            if (verticalMove <= -.5f) { plateformes.enabled = false; } else if (verticalMove > -.5f) { plateformes.enabled = true; }
        }

    }
}
