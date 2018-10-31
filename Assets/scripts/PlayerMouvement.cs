using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour {


    public float runSpeed = 40f;
    public Joystick joystick;
    private bool mobile;
    private GameObject GameManager;
    private ManageGame gameManagerScript;
    public Canvas joystickCanvas;

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    public static bool jump = false;
    public static bool crouch = false;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gameManagerScript = GameManager.GetComponent<ManageGame>();
        mobile = gameManagerScript.mobile;
        if(mobile == false)
        {
            joystickCanvas.enabled = false;
            controller.m_JumpForce = 1000f;
        }
        else if(mobile == true)
        {
            joystickCanvas.enabled = true;
            controller.m_JumpForce = 400f;
        }
    }

    // Update is called once per frame
    void Update () {

        if (mobile == false)
        {
            //Mouvements horizontaux
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
            //Sauter
            if (Input.GetButtonDown("Jump")) { jump = true; }
            //S'accroupir
            if (Input.GetButtonDown("Crouch")) { crouch = true; } else if (Input.GetButtonUp("Crouch")) { crouch = false; }
        }
        if (mobile == true)
        {
            //Mouvements horizontaux
            horizontalMove = joystick.Horizontal * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            float verticalMove = joystick.Vertical;
            //Sauter
            if (verticalMove >= .5f) { jump = true; verticalMove = 0f; }
            //S'accroupir
            if (verticalMove <= -.5f) { crouch = true; } else { crouch = false; }
        }
    }

    public void OnCrouching(bool isCrouching) { animator.SetBool("IsCrouching", isCrouching); }

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
