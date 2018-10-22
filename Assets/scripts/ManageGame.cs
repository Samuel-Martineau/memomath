using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour {

    public GameObject Player;


    public void EndGame ()
    {
        Debug.LogWarning("Le joueur est mort"); 
        Time.timeScale = 0f;
    }
}
