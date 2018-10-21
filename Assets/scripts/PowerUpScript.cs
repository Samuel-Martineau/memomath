using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {
    GameObject cerise;

    private void Start()
    {
        cerise = gameObject;
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("cerise");
            Destroy(cerise);
        }
        
    }
}
