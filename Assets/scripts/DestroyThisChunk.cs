using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisChunk : MonoBehaviour {

    private GameObject chunk;

    private void Update()
    {
        if(gameObject.name == "First_Chunk")
        {
            DestroyThisOldChunk();
        }
    }

    public void DestroyThisOldChunk () {
        Destroy(gameObject);
    }

}
