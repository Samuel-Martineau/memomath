using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadALevel : MonoBehaviour {

    public int sceneIndex;

    public LevelLoader script;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            script.FadeToLevel(sceneIndex);
        }
    }
}
