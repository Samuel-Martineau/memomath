using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class démarer_le_jeu : MonoBehaviour {

    public string DoorName;
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player"){
            Debug.Log("Le joueur veut entrer dans " + DoorName);
        }
    }

}
