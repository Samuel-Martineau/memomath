using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour {

    public Transform PosGenerate;
    public GameObject Motif;
    public GameObject[] ListOfchunks;
    public GameObject[] Motifs;
    public GameObject camera;
    public int MotifsLength;
    public int random;
    CameraMouvement cameraScript;

    private void Start()
    {
        camera = GameObject.Find("Main Camera");
        cameraScript = camera.GetComponent<CameraMouvement>();
    }

    public void ChooseMotif ()
    {
        random = Random.Range(0, MotifsLength);
        Motif = Motifs[random];
    }

    public void GenerateChunk ()
    {
        ChooseMotif();
        Instantiate(Motif, PosGenerate.position, PosGenerate.rotation);
        gameObject.transform.Translate(22f, 0f, 0f);
        ListOfchunks = GameObject.FindGameObjectsWithTag("Chunk");
    }
    public void DestroyAllChunks ()
    {
        GameObject[] chunks = GameObject.FindGameObjectsWithTag("Chunk");
        foreach (GameObject chunk in chunks) { GameObject.DestroyImmediate(chunk); }
        ListOfchunks = GameObject.FindGameObjectsWithTag("Chunk");
        ResetTransform();
    }
    public void ResetTransform()
    {
        gameObject.transform.position = new Vector2(44f, 0f);
    }

    private void Update()
    {
        MotifsLength = Motifs.Length;

        ListOfchunks = GameObject.FindGameObjectsWithTag("Chunk");

        if (cameraScript.UnitParcouru >= 22)
        {
            GenerateChunk();
            cameraScript.UnitParcouru = 0;
        }


        if (ListOfchunks.Length == 5) 
        {
            GameObject ChunkToDestroy = ListOfchunks[0];
            ChunkToDestroy.name = "First_Chunk";
            ListOfchunks = GameObject.FindGameObjectsWithTag("Chunk");
        }
    }
}
