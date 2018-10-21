using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    public GameObject loadingScreen;
    public GameObject FadeScreen;
    public Slider slider;
    public Text progressText;
    private int SceneIndex;
    public Animator animator;


    private void Start()
    {
        FadeScreen.SetActive(true);
        loadingScreen.SetActive(false);
    }

    public void FadeToLevel (int sceneIndex)
    {
        SceneIndex = sceneIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete ()
    {
        LoadLevel(SceneIndex);
    }

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }
    
}
