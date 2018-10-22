using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AskQuestion))]
public class QuestionEditor : Editor {

    public override void OnInspectorGUI()
    {
        AskQuestion askQuestion = (AskQuestion)target;

        if (GUILayout.Button("Créer la bonne réponse"))
        {
            askQuestion.CreateGoodAnswer();
        }
        if (GUILayout.Button("Demander une question"))
        {
            askQuestion.Ask_Question();
        }

        base.OnInspectorGUI();
    }
}
