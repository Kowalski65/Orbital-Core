using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Typewritter : MonoBehaviour
{
    public TMP_Text uiText;
    public string fullText;
    public float delay = 0.05f;
    private void Start()
    {
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        uiText.text = "";
        for (int i = 0; i < fullText.Length; i++)
        {
            uiText.text += fullText[i];
            yield return new WaitForSeconds(delay);
        }
    }
}
