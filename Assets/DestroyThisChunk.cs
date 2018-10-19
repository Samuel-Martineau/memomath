using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisChunk : MonoBehaviour {

    public float targetTimer = 30f;

    private void Update()
    {
        targetTimer -= Time.deltaTime;
        if(targetTimer <= 0.0f)
        {
            DestroyThisOldChunk();
        }
    }

    public void DestroyThisOldChunk () {
        Destroy(gameObject);
    }

}
