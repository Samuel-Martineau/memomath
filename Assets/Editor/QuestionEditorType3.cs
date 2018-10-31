using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AskQuestionType3))]
public class QuestionEditorType3 : Editor {

    public override void OnInspectorGUI()
    {
        AskQuestionType3 askQuestion = (AskQuestionType3)target;

        if(GUILayout.Button("Demander une Question"))
        {
            askQuestion.Ask_Question();
        }

        base.OnInspectorGUI();
    }
}
