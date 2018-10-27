using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AskQuestionType1))]
public class QuestionEditorType1 : Editor {

    public override void OnInspectorGUI()
    {
        AskQuestionType1 askQuestion = (AskQuestionType1)target;


        if (GUILayout.Button("Demander une question"))
        {
            askQuestion.Ask_Question();
        }

        base.OnInspectorGUI();
    }
}
