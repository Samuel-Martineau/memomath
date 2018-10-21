using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateformeScript : MonoBehaviour {

    public Collider2D plateformes;

    private void Update()
    {
        if (Input.GetButtonDown("Crouch")) { plateformes.enabled = false; } else if (Input.GetButtonUp("Crouch")) { plateformes.enabled = true; }
    }
}
