using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateformeScript : MonoBehaviour {

    public Collider2D plateformes;
	
	// Update is called once per frame
	void Update () {

        if (PlayerMouvement.jump ==true)
        {
            plateformes.enabled = !plateformes.enabled;
        }

	}
}
