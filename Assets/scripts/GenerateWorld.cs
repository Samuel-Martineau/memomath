using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour {

    public Transform PosGenerate;
    public GameObject Motif1;



	// Update is called once per frame
	void Update () 
    {

	}

    public void GenerateChunk ()
    {
        Instantiate(Motif1, PosGenerate.position, PosGenerate.rotation);
        gameObject.transform.Translate(22f, 0f, 0f);
    }
    public void DestroyAllChunks ()
    {
        GameObject[] chunks = GameObject.FindGameObjectsWithTag("Chunk");
        foreach (GameObject chunk in chunks) { GameObject.DestroyImmediate(chunk); }
        ResetTransform();
    }
    public void ResetTransform()
    {
        gameObject.transform.position = new Vector2(0f, 0f);
    }
}
