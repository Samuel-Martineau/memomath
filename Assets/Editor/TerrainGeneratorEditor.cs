using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GenerateWorld))]
public class TerrainGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GenerateWorld generate = (GenerateWorld)target;

        if(GUILayout.Button("Generate chunk!"))
        {
            generate.GenerateChunk();
        }

        if (GUILayout.Button("Destroy all chunks"))
        {
            generate.DestroyAllChunks();
        }
        if (GUILayout.Button("Reset the transform"))
        {
            generate.ResetTransform();
        }
    }

}
