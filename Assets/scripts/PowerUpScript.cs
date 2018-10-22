using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {


        Destroy(gameObject);
        Debug.LogWarning("cerise");
    }

}
