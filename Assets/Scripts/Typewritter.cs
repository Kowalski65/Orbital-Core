using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typewriter : MonoBehaviour
{
    public TMP_Text uiText;         
    public TMP_Text extraText;      
    public Image image1;            
               

    public float delay = 0.05f;
    public List<string> texts;      

    private int currentIndex = 0;
    private Coroutine typingCoroutine;

    private void Start()
    {
        StartTyping();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClickAction();
        }
    }

    void OnClickAction()
    {
        
        if (extraText != null) extraText.enabled = false;

        
        if (image1 != null) image1.enabled = false;
        

        
        currentIndex = (currentIndex + 1) % texts.Count;
        StartTyping();
    }

    void StartTyping()
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(ShowText(texts[currentIndex]));
    }

    IEnumerator ShowText(string fullText)
    {
        uiText.text = "";
        for (int i = 0; i < fullText.Length; i++)
        {
            uiText.text += fullText[i];
            yield return new WaitForSeconds(delay);
        }
    }
}
