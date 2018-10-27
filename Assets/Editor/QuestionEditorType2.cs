using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AskQuestionType2))]
public class QuestionEditorType2 : Editor {

    public override void OnInspectorGUI()
    {
        AskQuestionType2 askQuestion = (AskQuestionType2)target;

        if(GUILayout.Button("Demander une question"))
        {
            askQuestion.Ask_Question();
        }

        base.OnInspectorGUI();
    }
}
