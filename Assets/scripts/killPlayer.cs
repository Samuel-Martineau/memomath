using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour {

    public ManageGame script;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            KillThePlayer(collision.gameObject);
        }
    }

    public void KillThePlayer (GameObject player)
    {
        Destroy(player);
        script.EndGame();
    }

}
