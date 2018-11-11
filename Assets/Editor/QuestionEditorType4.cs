using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AskQuestionType4))]
public class QuestionEditorType4 : Editor {

    public override void OnInspectorGUI()
    {
        AskQuestionType4 askQuestion = (AskQuestionType4)target;

        if (GUILayout.Button("Demander une question"))
        {
            askQuestion.Ask_Question();
        }

        base.OnInspectorGUI();
    }
}
