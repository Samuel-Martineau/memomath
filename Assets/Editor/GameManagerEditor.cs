using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ManageGame))]
public class GameManagerEditor : Editor {

    public override void OnInspectorGUI()
    {
        ManageGame askQuestion = (ManageGame)target;
        if (GUILayout.Button("Reset PlayerPrefs"))
        {
            askQuestion.ResetPlayerPrefs();
        }
        base.OnInspectorGUI();
    }
}
