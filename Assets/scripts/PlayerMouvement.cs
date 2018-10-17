using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour {


    public bool IsClimbing;

    public float ClimbSpeed = 400f;

    public float runSpeed = 40f;

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    public static bool jump = false;
    public static bool crouch = false;

	// Update is called once per frame
	void Update () {
        //Mouvements horizontaux
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        //Sauter
        if (Input.GetButtonDown("Jump")) { jump = true;}
        //S'accroupir
        if (Input.GetButtonDown("Crouch")) { crouch = true; } else if (Input.GetButtonUp("Crouch")) {crouch = false;}
	}

    public void OnCrouching(bool isCrouching) { animator.SetBool("IsCrouching", isCrouching); }

    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
