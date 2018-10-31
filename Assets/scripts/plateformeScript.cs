using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateformeScript : MonoBehaviour {

    public Collider2D plateformes;
    public Joystick joystick;

    private void Start()
    {
        joystick = GameObject.Find("JoyStick").GetComponentInChildren<Joystick>();
    }

    private void Update()
    {
        float verticalMove = joystick.Vertical;
        if (Input.GetButtonDown("Crouch")) { plateformes.enabled = false; } else if (Input.GetButtonUp("Crouch")) { plateformes.enabled = true; }
        if (verticalMove <= -.5f) { plateformes.enabled = false; } else { plateformes.enabled = true; }

    }
}
