using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreenManager : MonoBehaviour
{
    public CanvasGroup logoCanvasGroup; // ????????????? ? ??????????
    public float fadeDuration = 2f;
    public float waitAfterFade = 1f;
    public string nextSceneName = "MainMenu";

    void Start()
    {
        StartCoroutine(FadeInAndLoad());
    }

    IEnumerator FadeInAndLoad()
    {
        
        float timer = 0f;
        logoCanvasGroup.alpha = 0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            logoCanvasGroup.alpha = Mathf.Lerp(0f, 1f, timer / fadeDuration);
            yield return null;
        }

        logoCanvasGroup.alpha = 1f;

        
        yield return new WaitForSeconds(waitAfterFade);

        
        SceneManager.LoadScene(nextSceneName);
    }
}
